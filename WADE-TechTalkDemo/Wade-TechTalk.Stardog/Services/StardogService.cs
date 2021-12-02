using Semiodesk.Trinity;
using System;
using System.IO;
using System.Reflection;
using VDS.RDF.Storage;

namespace Wade_TechTalk.Stardog.Services
{
    public class StardogService
    {
        protected readonly string _serverAddress;
        protected readonly string _databaseName;
        protected readonly string _username;
        protected readonly string _password;

        public StardogService(string serverAddress, string databaseName, string username, string password)
        {
            _serverAddress = serverAddress;
            _databaseName = databaseName;
            _username = username;
            _password = password;
        }

        public StardogConnector GetStardogConnector()
        {
            //var connectionString = $"provider=stardog;host={_serverAddress};uid={_username};pw={_password};sid={_databaseName}";
            //OntologyDiscovery.AddAssembly(Assembly.GetExecutingAssembly());
            //MappingDiscovery.RegisterCallingAssembly();
            //StoreFactory.LoadProvider<StardogStoreProvider>();
            //IStore store = StoreFactory.CreateStore(connectionString);
            //store.InitializeFromConfiguration(Path.Combine(Environment.CurrentDirectory, "ontologies.config"));
            return new StardogConnector(_serverAddress, _databaseName, _username, _password);
          
        }
    }
}
