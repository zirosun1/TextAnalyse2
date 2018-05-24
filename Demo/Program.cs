using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyse;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Properties.Settings.Default.path;
            string writePath = Properties.Settings.Default.writePath;
            string result = Analizator.AnaliseText(FileIO.ReadFile(path));
            FileIO.WriteFile(writePath, result);
            Console.ReadLine();
        }
    }
}
