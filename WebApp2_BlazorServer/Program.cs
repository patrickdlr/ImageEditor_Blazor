using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using SixLabors.ImageSharp;
using System.IO;

namespace WebApp2_BlazorServer {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();


            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
