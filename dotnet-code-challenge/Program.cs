using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StructureMap;
using System;


namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setup DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IReadData, ReadData>()
                .BuildServiceProvider();
            //Configure console loggin

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();

            logger.LogDebug("Start Application");

            var bar = serviceProvider.GetService<IReadData>();
            bar.GetFileData();
            logger.LogDebug("All Done ");
            Console.WriteLine("Test");

            //add framework service 
            var service = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IReadData, ReadData>();

            //add structureMapping
            var container = new Container();
            container.Configure(config =>
            {
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                });
                //Populate container with service collection
                config.Populate(service);
            });
            var serviceProvider1 = container.GetInstance<IServiceProvider>();
            serviceProvider1.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);
            var logger1 = serviceProvider1.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger1.LogDebug("Start Application 1");
            var bar1 = serviceProvider1.GetService<IReadData>();
            bar1.GetFileData();
        }
    }
}
