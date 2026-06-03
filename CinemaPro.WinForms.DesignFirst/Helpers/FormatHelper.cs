using System.Globalization;

namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class FormatHelper
{
    public static string Vnd(decimal amount)
    {
        return string.Format(CultureInfo.GetCultureInfo("vi-VN"), "{0:N0} đ", amount);
    }

    public static string TicketStatusText(string status)
    {
        return status switch
        {
            "Unused" => "Chưa sử dụng",
            "Used" => "Đã sử dụng",
            "Canceled" or "Cancelled" => "Đã hủy",
            _ => status
        };
    }

    public static string ShowtimeStatusText(string status)
    {
        return status switch
        {
            "Open" => "Đang bán",
            "Closed" => "Đã đóng",
            "Cancelled" => "Đã hủy",
            "Finished" => "Đã chiếu",
            _ => status
        };
    }
}
