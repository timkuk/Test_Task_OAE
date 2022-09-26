using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Test_Task_OAE
{
    public class JsonWorker
    {
        public string GetStringValue(string pathJson, string path)
        {
            var valueFromFile = File.ReadAllText(path);
            var j = JObject.Parse(valueFromFile);
            var token = j.SelectToken(pathJson);

            if(token == null)
            {
                throw new NullReferenceException(); 
            }

            return token.ToString();
        }
    }
}
