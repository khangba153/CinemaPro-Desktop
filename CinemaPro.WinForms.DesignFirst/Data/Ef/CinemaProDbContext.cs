using CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.WinForms.DesignFirst.Data.Ef;

public sealed class CinemaProDbContext : DbContext
{
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<AppSettingEntity> AppSettings => Set<AppSettingEntity>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(AppDbConfig.ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureUsers(modelBuilder);
        ConfigureAppSettings(modelBuilder);
    }

    private static void ConfigureUsers(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<UserEntity>();

        entity.ToTable("Users", "dbo");
        entity.HasKey(user => user.UserId);
        entity.HasIndex(user => user.UserCode).IsUnique();
        entity.HasIndex(user => user.Username).IsUnique();

        entity.Property(user => user.UserCode).HasMaxLength(20).IsRequired();
        entity.Property(user => user.FullName).HasMaxLength(100).IsRequired();
        entity.Property(user => user.Username).HasMaxLength(50).IsRequired();
        entity.Property(user => user.PasswordHash).HasMaxLength(255).IsRequired();
        entity.Property(user => user.Role).HasMaxLength(20).IsRequired();
        entity.Property(user => user.UserStatus).HasMaxLength(20).IsRequired();
        entity.Property(user => user.CreatedAt)
            .HasColumnType("datetime2(0)")
            .HasDefaultValueSql("SYSDATETIME()")
            .ValueGeneratedOnAdd();
        entity.Property(user => user.UpdatedAt).HasColumnType("datetime2(0)");
    }

    private static void ConfigureAppSettings(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<AppSettingEntity>();

        entity.ToTable("AppSettings", "dbo");
        entity.HasKey(setting => setting.AppSettingId);
        entity.HasIndex(setting => setting.SettingKey).IsUnique();

        entity.Property(setting => setting.SettingKey).HasMaxLength(100).IsRequired();
        entity.Property(setting => setting.SettingValue).HasMaxLength(500);
        entity.Property(setting => setting.Description).HasMaxLength(255);
        entity.Property(setting => setting.UpdatedAt)
            .HasColumnType("datetime2(0)")
            .HasDefaultValueSql("SYSDATETIME()")
            .ValueGeneratedOnAdd();
    }
}
