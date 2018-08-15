using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Terminal
{
    class Program
    {

        public static IConfiguration configuration;

        static void Main(string[] args)
        {
            // Init config file
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();

            Console.WriteLine("test: " + configuration["window:width"]);

            // Start game loop
            GameManager gameManager = new GameManager();
            gameManager.Init();

        }
    }
}
