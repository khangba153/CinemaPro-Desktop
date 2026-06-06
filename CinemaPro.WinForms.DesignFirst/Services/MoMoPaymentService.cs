using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using CinemaPro.WinForms.DesignFirst.Helpers;
using CinemaPro.WinForms.DesignFirst.Models;

namespace CinemaPro.WinForms.DesignFirst.Services;

public class MoMoPaymentService
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public async Task<(string? qrUrl, string? payUrl, string? error)> CreatePaymentRequestAsync(decimal amount, string orderInfo, string orderId, string requestId)
    {
        try
        {
            string amountStr = ((long)amount).ToString();
            
            string requestType = "payWithATM";
            
            string rawSignature = $"accessKey={MoMoConfig.AccessKey}&amount={amountStr}&extraData=&ipnUrl={MoMoConfig.IpnUrl}&orderId={orderId}&orderInfo={orderInfo}&partnerCode={MoMoConfig.PartnerCode}&redirectUrl={MoMoConfig.RedirectUrl}&requestId={requestId}&requestType={requestType}";
            string signature = MoMoSecurity.SignSHA256(rawSignature, MoMoConfig.SecretKey);

            var requestData = new
            {
                partnerCode = MoMoConfig.PartnerCode,
                partnerName = "CinemaPro Sandbox",
                storeId = "CinemaPro_Store",
                requestId = requestId,
                amount = amountStr,
                orderId = orderId,
                orderInfo = orderInfo,
                redirectUrl = MoMoConfig.RedirectUrl,
                ipnUrl = MoMoConfig.IpnUrl,
                lang = "vi",
                extraData = "",
                requestType = requestType,
                signature = signature
            };

            string jsonRequest = JsonSerializer.Serialize(requestData);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(MoMoConfig.PaymentEndpoint, content);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            var jsonNode = JsonNode.Parse(jsonResponse);
            
            string? qrUrl = jsonNode?["qrCodeUrl"]?.ToString();
            string? payUrl = jsonNode?["payUrl"]?.ToString();

            if (!string.IsNullOrEmpty(payUrl) && string.IsNullOrEmpty(qrUrl))
            {
                qrUrl = "https://api.qrserver.com/v1/create-qr-code/?size=300x300&data=" + Uri.EscapeDataString(payUrl);
            }

            if (!string.IsNullOrEmpty(qrUrl) || !string.IsNullOrEmpty(payUrl))
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
        string rawSignature = $"accessKey={MoMoConfig.AccessKey}&orderId={orderId}&partnerCode={MoMoConfig.PartnerCode}&requestId={requestId}";
        string signature = MoMoSecurity.SignSHA256(rawSignature, MoMoConfig.SecretKey);

        var requestData = new
        {
            partnerCode = MoMoConfig.PartnerCode,
            requestId = requestId,
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

        if (jsonNode?["resultCode"] != null)
        {
            int resultCode = (int)jsonNode["resultCode"]!;
            return resultCode == 0;
        }

        return false;
    }
}
