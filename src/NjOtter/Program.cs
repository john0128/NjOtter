using System;
using System.IO;

namespace NjOtter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.Title = "NjOtter CLI Enviornment";
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folpath = doc + "/NjOtter Saves";
            DirectoryInfo di = new DirectoryInfo(folpath);
            if (di.Exists == false)
            {
                di.Create();
            }
            Main main = new Main();
            main.Start();
        }
    }
}
