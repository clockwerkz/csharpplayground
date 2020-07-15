using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    class DataAccess : IDataAccess
    {
        public void SaveData(string name)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Saving { name }");
            Console.ResetColor();
        }

        public void LoadData()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Loading Data");
            Console.ResetColor();
        }
    }
}
