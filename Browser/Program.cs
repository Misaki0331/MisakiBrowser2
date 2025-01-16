namespace Browser
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<string> list = new List<string>();
            for(int i = 0; i < args.Length; i++) list.Add(args[i]); 
            Application.Run(new Form1(list));
        }
    }
}