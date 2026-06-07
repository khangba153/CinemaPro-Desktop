using CinemaPro.WinForms.DesignFirst.Data.Ef;
using CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.WinForms.DesignFirst.Repositories.Ef;

public sealed class EfAppSettingRepository
{
    public Dictionary<string, string> GetAllAsDictionary()
    {
        using var db = new CinemaProDbContext();

        return db.AppSettings
            .AsNoTracking()
            .OrderBy(setting => setting.SettingKey)
            .ToDictionary(
                setting => setting.SettingKey,
                setting => setting.SettingValue ?? "",
                StringComparer.OrdinalIgnoreCase);
    }

    public void Upsert(string key, string value, string description)
    {
        using var db = new CinemaProDbContext();

        var entity = db.AppSettings.FirstOrDefault(setting => setting.SettingKey == key);
        if (entity is null)
        {
            db.AppSettings.Add(new AppSettingEntity
            {
                SettingKey = key,
                SettingValue = value,
                Description = description
            });
        }
        else
        {
            entity.SettingValue = value;
            entity.Description = description;
            entity.UpdatedAt = DateTime.Now;
        }

        db.SaveChanges();
    }
}
