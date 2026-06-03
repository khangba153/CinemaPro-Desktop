namespace CinemaPro.WinForms.DesignFirst.Models;

public sealed class AppSetting
{
    public int AppSettingId { get; set; }
    public string SettingKey { get; set; } = "";
    public string SettingValue { get; set; } = "";
    public string Description { get; set; } = "";
    public DateTime UpdatedAt { get; set; }
}
