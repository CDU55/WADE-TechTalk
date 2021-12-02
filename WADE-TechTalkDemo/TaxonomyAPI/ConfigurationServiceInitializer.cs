using Microsoft.Extensions.Configuration;
using Wade_TechTalk.Stardog.Services;

namespace TaxonomyAPI
{
    public static class ConfigurationServiceInitializer
    {
        public static TaxonomyService BuildStardogService(IConfiguration config)
        {
            var stardogSection = config.GetSection("Stardog");
            var serverAddress = stardogSection.GetValue("Server", "http://localhost:5820");
            var databaseName = stardogSection.GetValue("Database", "Taxonomy");
            var userName = stardogSection.GetValue("User", "admin");
            var password = stardogSection.GetValue("Password", "admin");
            return new TaxonomyService(serverAddress, databaseName, userName, password);
        }
    }
}
