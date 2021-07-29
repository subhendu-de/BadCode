using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DIDemo
{
    public interface ILogger
    {
        Task LogInformation(string data);
    }

    public class Logger: ILogger
    {
        public Logger() 
        { 
            // not implemented
        }

        public Task LogInformation(string data)
        {
            // not implemented
        }
    }

    class Program
    {
        static void main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            services.AddSingleton<ILogger, Logger>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var log = serviceProvider.GetService<ILogger>();
        }
    }
}