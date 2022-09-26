using System;
using System.IO;

//1.JSON text from file on disk - without any defined structure, so we do not know what is inside.
//2. Path to JSON element that tells you 'which element from JSON to take' - path format you can decide on 
//Your app should search for JSON element via JSON path, convert element to string and print in console app as output

namespace Test_Task_OAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var path = Path.Combine(Path.GetFullPath(@"test.json"));
                var jsonWorker = new JsonWorker();
                Console.WriteLine("Input JSON Path");
                //car.type[0].sedan.make for example
                var input = Console.ReadLine();
                var result = jsonWorker.GetStringValue(input, path);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Input invalid JSON path");
            }     
        }
    }
}
