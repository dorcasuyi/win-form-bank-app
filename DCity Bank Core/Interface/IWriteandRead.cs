using System.Collections.Generic;

namespace DCity_Bank_Core.Interface
{
    public interface IWriteandRead
    {
        List<string> readFile(string path);
        bool WriteToFile(string path, List<string> data);
    }
}