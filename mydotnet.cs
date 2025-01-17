using Newtonsoft.Json;
using System;

namespace MyDotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new { Name = "pranith", Age = 23 };
            string json = JsonConvert.SerializeObject(person);
            Console.WriteLine(json);
        }
    }
}
