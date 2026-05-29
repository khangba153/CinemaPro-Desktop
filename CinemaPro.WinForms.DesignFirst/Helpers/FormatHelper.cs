namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class FormatHelper
{
    public static string Vnd(decimal amount)
    {
        return string.Format(System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} đ", amount);
    }

    public static string TicketStatusText(string status)
    {
        return status switch
        {
            "Unused" => "Chưa sử dụng",
            "Used" => "Đã sử dụng",
            "Canceled" => "Đã hủy",
            _ => status
        };
    }
}
