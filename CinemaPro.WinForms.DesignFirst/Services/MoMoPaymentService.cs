using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public class MoMoPaymentService
{
    private const string RequestType = "captureWallet";
    private const string ExtraData = "";
    private const long MinimumAmount = 1000;
    private const long MaximumAmount = 50000000;
    private static readonly HttpClient _httpClient = new()
    {
        Timeout = TimeSpan.FromSeconds(35)
    };

    public async Task<(string? qrUrl, string? payUrl, string? error)> CreatePaymentRequestAsync(decimal amount, string orderInfo, string orderId, string requestId)
    {
        try
        {
            long amountValue = (long)amount;
            if (amountValue < MinimumAmount || amountValue > MaximumAmount)
            {
                return (null, null, $"Số tiền MoMo phải từ {MinimumAmount:N0} đến {MaximumAmount:N0} VND.");
            }

            string amountStr = amountValue.ToString();
            string normalizedOrderInfo = NormalizeOrderInfo(orderInfo);
            
            string rawSignature = $"accessKey={MoMoConfig.AccessKey}&amount={amountStr}&extraData={ExtraData}&ipnUrl={MoMoConfig.IpnUrl}&orderId={orderId}&orderInfo={normalizedOrderInfo}&partnerCode={MoMoConfig.PartnerCode}&redirectUrl={MoMoConfig.RedirectUrl}&requestId={requestId}&requestType={RequestType}";
            string signature = MoMoSecurity.SignSHA256(rawSignature, MoMoConfig.SecretKey);

            var requestData = new
            {
                partnerCode = MoMoConfig.PartnerCode,
                partnerName = "CinemaPro Sandbox",
                storeId = "CinemaPro_Store",
                requestId = requestId,
                amount = amountStr,
                orderId = orderId,
                orderInfo = normalizedOrderInfo,
                redirectUrl = MoMoConfig.RedirectUrl,
                ipnUrl = MoMoConfig.IpnUrl,
                lang = "vi",
                extraData = ExtraData,
                requestType = RequestType,
                signature = signature
            };

            string jsonRequest = JsonSerializer.Serialize(requestData);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(MoMoConfig.PaymentEndpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonNode = JsonNode.Parse(jsonResponse);

            var resultCode = GetIntValue(jsonNode?["resultCode"]);
            if (resultCode is not null && resultCode != 0)
            {
                var message = jsonNode?["message"]?.ToString() ?? jsonResponse;
                return (null, null, $"MoMo trả lỗi {resultCode}: {message}");
            }

            string? qrData = jsonNode?["qrCodeUrl"]?.ToString();
            string? payUrl = jsonNode?["payUrl"]?.ToString();
            string? qrContent = !string.IsNullOrWhiteSpace(qrData) ? qrData : payUrl;
            string? qrUrl = CreateQrImageUrl(qrContent);

            if (!string.IsNullOrWhiteSpace(qrUrl) || !string.IsNullOrWhiteSpace(payUrl))
            {
                return (qrUrl, payUrl, null);
            }
            
            return (null, null, "Lỗi từ MoMo: " + jsonResponse);
        }
        catch (Exception ex)
        {
            return (null, null, "Lỗi kết nối: " + ex.Message);
        }
    }

    public async Task<bool> CheckTransactionStatusAsync(string orderId, string requestId)
    {
        try
        {
            string queryRequestId = CreateQueryRequestId(requestId);
            string rawSignature = $"accessKey={MoMoConfig.AccessKey}&orderId={orderId}&partnerCode={MoMoConfig.PartnerCode}&requestId={queryRequestId}";
            string signature = MoMoSecurity.SignSHA256(rawSignature, MoMoConfig.SecretKey);

            var requestData = new
            {
                partnerCode = MoMoConfig.PartnerCode,
                requestId = queryRequestId,
                orderId = orderId,
                signature = signature,
                lang = "vi"
            };

            string jsonRequest = JsonSerializer.Serialize(requestData);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(MoMoConfig.QueryEndpoint, content);
            if (!response.IsSuccessStatusCode) return false;

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonNode = JsonNode.Parse(jsonResponse);

            return GetIntValue(jsonNode?["resultCode"]) == 0;
        }
        catch
        {
            return false;
        }
    }

    private static string? CreateQrImageUrl(string? qrContent)
    {
        if (string.IsNullOrWhiteSpace(qrContent))
        {
            return null;
        }

        // MoMo trả qrCodeUrl là dữ liệu QR, không phải đường dẫn ảnh QR.
        return "https://api.qrserver.com/v1/create-qr-code/?size=300x300&data=" + Uri.EscapeDataString(qrContent);
    }

    private static int? GetIntValue(JsonNode? node)
    {
        return int.TryParse(node?.ToString(), out var value) ? value : null;
    }

    private static string NormalizeOrderInfo(string orderInfo)
    {
        var value = string.IsNullOrWhiteSpace(orderInfo)
            ? "CinemaPro payment"
            : orderInfo.Trim();

        return value.Length <= 250 ? value : value[..250];
    }

    private static string CreateQueryRequestId(string originalRequestId)
    {
        var prefix = string.IsNullOrWhiteSpace(originalRequestId)
            ? "CP"
            : originalRequestId.Trim();

        if (prefix.Length > 36)
        {
            prefix = prefix[..36];
        }

        return $"{prefix}-{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}";
    }
}
