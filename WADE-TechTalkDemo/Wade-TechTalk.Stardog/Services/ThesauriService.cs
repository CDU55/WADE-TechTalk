using System.Collections.Generic;
using VDS.RDF.Query;
using VDS.RDF.Storage;
using Wade_TechTalk.Stardog.Models;

namespace Wade_TechTalk.Stardog.Services
{
    public class ThesauriService : StardogService
    {
        public ThesauriService(string serverAddress, string databaseName, string username, string password) : base(serverAddress, databaseName, username, password)
        {
        }

        public List<Concept> GetAll()
        {
            var connector = GetStardogConnector();
            var query = "SELECT DISTINCT * {?u skos:prefLabel ?t_eng;skos:prefLabel ?t_de FILTER(lang(?t_eng)='en' && lang(?t_de)='de')}";
            var result = (SparqlResultSet)connector.Query($"PREFIX {Prefix.SkosPrefix}  \n {query} ");
            return AssembleQueryResult(result);
        }

        public List<Concept> GetAllMathing(string pattern)
        {
            var connector = GetStardogConnector();
            var query = $"SELECT DISTINCT * {{?u skos:prefLabel ?t_eng;skos:prefLabel ?t_de FILTER(lang(?t_eng)='en' && lang(?t_de)='de' && (CONTAINS(STR(?t_end),'{pattern}') || CONTAINS(STR(?t_de),'{pattern}')))}}";
            var result = (SparqlResultSet)connector.Query($"PREFIX {Prefix.SkosPrefix}  \n {query} ");
            return AssembleQueryResult(result);
        }

        public Concept GetByUri(string uri)
        {
            var connector = GetStardogConnector();
            var query = $"SELECT * {{?u skos:prefLabel ?t_eng;skos:prefLabel ?t_de FILTER(lang(?t_eng)='en' && lang(?t_de)='de' && STR(?u)='{uri}')}} LIMIT 1";
            var result = (SparqlResultSet)connector.Query($"PREFIX {Prefix.SkosPrefix}  \n {query} ");
            return AssembleResult(result[0]);
        }

        public List<Concept> GetNarrowerConcepts(string uri)
        {
            var connector = GetStardogConnector();
            var query = $"SELECT * {{?W skos:narrower ?u. ?u skos:prefLabel ?t_eng . ?u skos:prefLabel ?t_de . FILTER(lang(?t_eng)='en' && lang(?t_de)='de' && STR(?W)='{uri}')}}";
            var queryWithPrefix = $"PREFIX {Prefix.SkosPrefix}  \n {query}";
            var result = (SparqlResultSet)connector.Query(queryWithPrefix);
            return AssembleQueryResult(result);
        }
        
        public List<Concept> GetBroaderConcepts(string uri)
        {
            var connector = GetStardogConnector();
            var query = $"SELECT * {{?W skos:broader ?u. ?u skos:prefLabel ?t_eng . ?u skos:prefLabel ?t_de . FILTER(lang(?t_eng)='en' && lang(?t_de)='de' && STR(?W)='{uri}')}}";
            var queryWithPrefix = $"PREFIX {Prefix.SkosPrefix}  \n {query}";
            var result = (SparqlResultSet)connector.Query(queryWithPrefix);
            return AssembleQueryResult(result);
        }

        public List<Concept> GetRelatedConcepts(string uri)
        {
            var connector = GetStardogConnector();
            var query = $"SELECT * {{?u skos:related ?W;skos:prefLabel ?t_eng;skos:prefLabel ?t_de FILTER(lang(?t_eng)='en' && lang(?t_de)='de' && STR(?W)='{uri}')}}";
            var queryWithPrefix = $"PREFIX {Prefix.SkosPrefix}  \n {query}";
            var result = (SparqlResultSet)connector.Query(queryWithPrefix);
            return AssembleQueryResult(result);
        }

        private List<Concept> AssembleQueryResult(SparqlResultSet resultSet)
        {
            var resultConcepts = new List<Concept>();
            foreach (var result in resultSet)
            {

                resultConcepts.Add(AssembleResult(result));
            }
            return resultConcepts;
        }

        private Concept AssembleResult(SparqlResult result)
        {
            var labelEng = result["t_eng"].ToString().Split("@")[0];
            var labelDe = result["t_de"].ToString().Split("@")[0];
            var concept = new Concept
            {
                Uri = result["u"].ToString(),
                PrefLabelEng = labelEng,
                PrefLabelDe = labelDe
            };
            return concept;
        }

        public Concept GetDetailed(string uri)
        {
            var concept = GetByUri(uri);
            concept.Related = GetRelatedConcepts(concept.Uri);
            concept.Broader = GetBroaderConcepts(concept.Uri);
            concept.Narrower = GetNarrowerConcepts(concept.Uri);
            return concept;
        }

    }
}
