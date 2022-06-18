namespace osu_consulter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainScreen());
        }
    }
}