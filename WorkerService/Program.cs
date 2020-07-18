using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nancy.Hosting.Self;

namespace WorkerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var url = new Uri("http://localhost:8080");
            var hostConfigs = new HostConfiguration()
            {
                UrlReservations = new UrlReservations {CreateAutomatically = true}
            };
            var host = new NancyHost(url, new BootStrapper(),hostConfigs);
            host.Start();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) => { services.AddHostedService<Worker>(); });
    }
}