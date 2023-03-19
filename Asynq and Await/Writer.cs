using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynq_and_Await
{
    public static class Writer
    {
        public static string SaveTextInFile(string text)
        {
            string fileName = text + ".txt";
            File.WriteAllText(fileName, text);
            return fileName;
        } 
    }
}
