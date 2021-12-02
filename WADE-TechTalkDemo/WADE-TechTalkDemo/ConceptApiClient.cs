using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using WADE_TechTalkDemo.Models;

namespace WADE_TechTalkDemo
{
    public class ConceptApiClient : ApiClient
    {
        public ConceptApiClient(string apiUrl) : base(apiUrl)
        {

        }

        public async Task<List<Concept>> GetConcepts()
        {
                var response = await HttpClient.GetAsync("Thesaurus").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var concepts = JsonConvert.DeserializeObject<List<Concept>>(responseString);
                    return concepts;
                }
            else
            {
                return new List<Concept>();
            }
        }

        public async Task<Concept> GetConceptDetails(string uri)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{HttpClient.BaseAddress}Thesaurus/GetDetails"),
                Content = new StringContent($"\"{uri}\"", Encoding.UTF8, MediaTypeNames.Application.Json ),
            };
            var response = await HttpClient.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var concepts = JsonConvert.DeserializeObject<Concept>(responseString);
                return concepts;
            }
            else
            {
                return new Concept();
            }
        }
    }
}
