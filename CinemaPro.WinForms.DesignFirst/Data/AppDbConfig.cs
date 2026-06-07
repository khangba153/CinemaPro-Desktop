namespace CinemaPro.WinForms.DesignFirst.Data
{
    public static class AppDbConfig
    {
        public static string ConnectionString { get; set; } =
            @"Server=ADMIN-PC\SQLEXPRESS;Database=CinemaProDB;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}