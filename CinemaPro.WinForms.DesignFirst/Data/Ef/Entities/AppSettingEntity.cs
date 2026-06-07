namespace CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;

public sealed class AppSettingEntity
{
    public int AppSettingId { get; set; }
    public string SettingKey { get; set; } = "";
    public string? SettingValue { get; set; }
    public string? Description { get; set; }
    public DateTime UpdatedAt { get; set; }
}
