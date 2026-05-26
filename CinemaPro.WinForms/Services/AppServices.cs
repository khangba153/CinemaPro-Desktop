using CinemaPro.WinForms.Services.Interfaces;

namespace CinemaPro.WinForms.Services;

public static class AppServices
{
    public static ICinemaDataStore CinemaStore { get; } = new FakeCinemaDataStore();
}
