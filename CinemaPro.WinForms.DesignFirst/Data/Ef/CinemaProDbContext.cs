using CinemaPro.WinForms.DesignFirst.Data.Ef.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.WinForms.DesignFirst.Data.Ef;

public sealed class CinemaProDbContext : DbContext
{
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<GenreEntity> Genres => Set<GenreEntity>();
    public DbSet<MovieEntity> Movies => Set<MovieEntity>();
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
        ConfigureGenres(modelBuilder);
        ConfigureMovies(modelBuilder);
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

    private static void ConfigureGenres(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<GenreEntity>();

        entity.ToTable("Genres", "dbo");
        entity.HasKey(genre => genre.GenreId);
        entity.HasIndex(genre => genre.GenreCode).IsUnique();
        entity.HasIndex(genre => genre.GenreName).IsUnique();

        entity.Property(genre => genre.GenreCode).HasMaxLength(20).IsRequired();
        entity.Property(genre => genre.GenreName).HasMaxLength(100).IsRequired();
        entity.Property(genre => genre.GenreStatus).HasMaxLength(20).IsRequired();
    }

    private static void ConfigureMovies(ModelBuilder modelBuilder)
    {
        var entity = modelBuilder.Entity<MovieEntity>();

        entity.ToTable("Movies", "dbo");
        entity.HasKey(movie => movie.MovieId);
        entity.HasIndex(movie => movie.MovieCode).IsUnique();

        entity.Property(movie => movie.MovieCode).HasMaxLength(20).IsRequired();
        entity.Property(movie => movie.MovieTitle).HasMaxLength(200).IsRequired();
        entity.Property(movie => movie.AgeRating).HasMaxLength(20).IsRequired();
        entity.Property(movie => movie.Director).HasMaxLength(120).IsRequired(false);
        entity.Property(movie => movie.MovieStatus).HasMaxLength(30).IsRequired();
        entity.Property(movie => movie.CreatedAt)
            .HasColumnType("datetime2(0)")
            .HasDefaultValueSql("SYSDATETIME()")
            .ValueGeneratedOnAdd();
        entity.Property(movie => movie.UpdatedAt).HasColumnType("datetime2(0)");

        entity.HasOne(movie => movie.Genre)
            .WithMany(genre => genre.Movies)
            .HasForeignKey(movie => movie.GenreId)
            .OnDelete(DeleteBehavior.Restrict);
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
