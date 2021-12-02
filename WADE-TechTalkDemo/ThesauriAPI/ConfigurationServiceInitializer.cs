using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wade_TechTalk.Stardog.Services;

namespace ThesauriAPI
{
    public static class ConfigurationServiceInitializer
    {
        public static ThesauriService BuildStardogService(IConfiguration config)
        {
            var stardogSection = config.GetSection("Stardog");
            var serverAddress = stardogSection.GetValue("Server", "http://localhost:5820");
            var databaseName = stardogSection.GetValue("Database", "Thesaurus");
            var userName = stardogSection.GetValue("User", "admin");
            var password = stardogSection.GetValue("Password", "admin");
            return new ThesauriService(serverAddress, databaseName, userName, password);
        }
    }
}
