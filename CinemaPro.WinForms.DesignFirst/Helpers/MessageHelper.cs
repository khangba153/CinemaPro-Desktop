namespace CinemaPro.WinForms.DesignFirst.Helpers;

public static class MessageHelper
{
    public static void Info(string message, string title = "CinemaPro")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void Warning(string message, string title = "CinemaPro")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void Error(string message, string title = "CinemaPro")
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static bool Confirm(string message, string title = "CinemaPro")
    {
        return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }
}
