using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ETicaret.Persistence
{
    internal static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager config = new ConfigurationManager();
                config.SetBasePath(
                    Path.Combine(Directory.GetCurrentDirectory(), "../ETicaret.API.Minimal"));
                config.AddJsonFile("appsettings.json");
                return config.GetConnectionString("postgresql");
            }
        }
    }
}