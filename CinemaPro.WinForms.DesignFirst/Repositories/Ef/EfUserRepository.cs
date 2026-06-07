using CinemaPro.WinForms.DesignFirst.Data.Ef;
using CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.WinForms.DesignFirst.Repositories.Ef;

public sealed class EfUserRepository
{
    public User? FindByUsername(string username)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Users
            .AsNoTracking()
            .FirstOrDefault(user => user.Username == username.Trim());

        return entity is null ? null : MapUser(entity);
    }

    public IReadOnlyList<User> GetAll()
    {
        using var db = new CinemaProDbContext();

        return db.Users
            .AsNoTracking()
            .OrderBy(user => user.UserId)
            .AsEnumerable()
            .Select(MapUser)
            .ToList();
    }

    public User? FindByCode(string userCode)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Users
            .AsNoTracking()
            .FirstOrDefault(user => user.UserCode == userCode);

        return entity is null ? null : MapUser(entity);
    }

    public bool UsernameExists(string username, string? exceptUserCode = null)
    {
        using var db = new CinemaProDbContext();

        username = username.Trim();

        return db.Users.Any(user =>
            user.Username == username &&
            (exceptUserCode == null || user.UserCode != exceptUserCode));
    }

    public string GetNextUserCode()
    {
        using var db = new CinemaProDbContext();

        var currentMax = db.Users
            .AsNoTracking()
            .Where(user => user.UserCode.StartsWith("U"))
            .Select(user => user.UserCode.Substring(1))
            .AsEnumerable()
            .Select(text => int.TryParse(text, out var number) ? number : 0)
            .DefaultIfEmpty(0)
            .Max();

        return "U" + (currentMax + 1).ToString("000");
    }

    public void Insert(User user)
    {
        using var db = new CinemaProDbContext();

        db.Users.Add(new UserEntity
        {
            UserCode = user.UserCode,
            FullName = user.FullName,
            Username = user.Username,
            PasswordHash = user.PasswordHash,
            Role = user.Role,
            UserStatus = user.UserStatus
        });

        db.SaveChanges();
    }

    public void Update(User user)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Users.FirstOrDefault(item => item.UserCode == user.UserCode);
        if (entity is null)
        {
            return;
        }

        entity.FullName = user.FullName;
        entity.Username = user.Username;
        entity.Role = user.Role;
        entity.UserStatus = user.UserStatus;
        entity.UpdatedAt = DateTime.Now;

        db.SaveChanges();
    }

    public void UpdateStatus(string userCode, string status)
    {
        using var db = new CinemaProDbContext();

        var entity = db.Users.FirstOrDefault(user => user.UserCode == userCode);
        if (entity is null)
        {
            return;
        }

        entity.UserStatus = status;
        entity.UpdatedAt = DateTime.Now;

        db.SaveChanges();
    }

    private static User MapUser(UserEntity entity)
    {
        return new User
        {
            UserId = entity.UserId,
            UserCode = entity.UserCode,
            FullName = entity.FullName,
            Username = entity.Username,
            PasswordHash = entity.PasswordHash,
            Role = entity.Role,
            UserStatus = entity.UserStatus,
            CreatedAt = entity.CreatedAt,
            UpdatedAt = entity.UpdatedAt
        };
    }
}
