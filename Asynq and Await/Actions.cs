using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynq_and_Await
{
    public sealed class Actions
    {
        public async void Run()
        {
            string hello = "Hello";
            string world = "World";
            Writer.SaveTextInFile(hello);
            Writer.SaveTextInFile(world);

            Task<string> firstText = Reader.ReadText(hello);
            Task<string> secondText = Reader.ReadText(world);

            await Task.WhenAll(firstText, secondText);

            string firstResult = await firstText;
            string secondResult = await secondText;

            Console.WriteLine(firstResult + " " + secondResult);
        }
    }
}
