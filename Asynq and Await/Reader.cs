using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynq_and_Await
{
    public static class Reader
    {
        public static Task<string> ReadText(string fileName)
        {
            string result = File.ReadAllText(fileName + ".txt");
            return Task.FromResult(result);
        }
    }
}
