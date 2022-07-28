namespace Rest4Eyes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SettingsForm());
            
        }
    }
}