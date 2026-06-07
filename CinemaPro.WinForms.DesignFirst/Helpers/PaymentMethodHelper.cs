namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class PaymentMethodHelper
{
    public const string Cash = "Cash";
    public const string VnPaySandbox = "VNPAY_SANDBOX";
    public const string MomoSandbox = "MOMO_SANDBOX";

    public const string CashDisplay = "Tiền mặt";
    public const string VnPaySandboxDisplay = "VNPAY Sandbox";
    public const string MomoSandboxDisplay = "Ví MoMo";

    public static string ToDatabaseValue(string paymentMethod)
    {
        if (paymentMethod.Contains("VNPAY", StringComparison.OrdinalIgnoreCase))
        {
            return VnPaySandbox;
        }

        if (paymentMethod.Contains("MoMo", StringComparison.OrdinalIgnoreCase)
            || paymentMethod.Equals("MOMO", StringComparison.OrdinalIgnoreCase))
        {
            return MomoSandbox;
        }

        return Cash;
    }

    public static string ToDisplayText(string paymentMethod)
    {
        return paymentMethod switch
        {
            Cash => CashDisplay,
            VnPaySandbox => VnPaySandboxDisplay,
            MomoSandbox => MomoSandboxDisplay,
            "MOMO" => MomoSandboxDisplay,
            _ => paymentMethod
        };
    }

    public static string ToShortDisplayText(string paymentMethod)
    {
        var displayText = ToDisplayText(paymentMethod);
        return displayText switch
        {
            VnPaySandboxDisplay => "VNPAY",
            MomoSandboxDisplay => "MoMo",
            _ => displayText
        };
    }
}
