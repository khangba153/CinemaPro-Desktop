using CinemaPro.WinForms.DesignFirst.Services.Interfaces;

namespace CinemaPro.WinForms.DesignFirst.Services;

public static class AppServices
{
    public static ICinemaDataStore CinemaStore { get; } = new FakeCinemaDataStore();
}
