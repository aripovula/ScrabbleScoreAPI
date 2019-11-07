using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ScrabbleScoreAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Dictionary<char, int> values = new Dictionary<int, string>()
            // {
            //     {1, "aeioulnrst"},
            //     {2, "dg"},
            //     {3, "bcmp"},
            //     {4, "fhvwy"},
            //     {5, "k"},
            //     {8, "jx"},
            //     {10, "qz"}
            // }.SelectMany(kv => kv.Value.Select(c => (c, kv.Key)))
            // .ToDictionary(kv => kv.c, kv => kv.Key);

            // foreach (var item in values) {
            //     Console.WriteLine(item.Key + " - " + item.Value);
            // }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
