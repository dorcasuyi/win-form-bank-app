using DCity_Bank_Core.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCity_Bank_Core.services
{
    public class WriteandRead : IWriteandRead
    {
        public List<string> readFile(string path)
        {
            List<string> pathlines = new List<string>();
            pathlines = File.ReadAllLines(path).ToList();
            return pathlines;
        }
        public bool WriteToFile(string path, List<string> data)
        {
            string dataToSave = "";
            foreach (var item in data)
            {
                dataToSave += item + ",";
            }
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(dataToSave);

            file.Close();

            return true;
        }
    }
}
