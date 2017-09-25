using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BestApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {          
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseConfiguration(new ConfigurationBuilder().AddCommandLine(args).Build())
                .Build();

            host.Run();
        }
    }
}
