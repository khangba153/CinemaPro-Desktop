namespace CinemaPro.WinForms.DesignFirst.Services;

public sealed class SettingService
{
    private readonly AppSettingRepository _settingRepository = new();

    public Dictionary<string, string> GetSettings()
    {
        return _settingRepository.GetAllAsDictionary();
    }

    public void SaveBasicSettings(
        string cinemaName,
        string cinemaAddress,
        string cinemaHotline,
        bool allowCashPayment,
        bool allowVnPaySandbox,
        bool allowMomoSandbox)
    {
        _settingRepository.Upsert("CinemaName", cinemaName.Trim(), "Tên rạp hiển thị trong phần mềm");
        _settingRepository.Upsert("CinemaAddress", cinemaAddress.Trim(), "Địa chỉ rạp");
        _settingRepository.Upsert("CinemaHotline", cinemaHotline.Trim(), "Hotline rạp");
        _settingRepository.Upsert("AllowCashPayment", allowCashPayment ? "true" : "false", "Bật/tắt thanh toán tiền mặt");
        _settingRepository.Upsert("AllowVnPaySandbox", allowVnPaySandbox ? "true" : "false", "Bật/tắt thanh toán VNPAY Sandbox giả lập");
        _settingRepository.Upsert("AllowMomoSandbox", allowMomoSandbox ? "true" : "false", "Bật/tắt thanh toán MoMo Sandbox giả lập");
    }
}
