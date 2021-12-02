using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VDS.RDF.Query;

namespace Wade_TechTalk.Stardog.Services
{
    public class TaxonomyService : StardogService
    {
        public TaxonomyService(string serverAddress, string databaseName, string username, string password) : base(serverAddress, databaseName, username, password)
        {
            
            
        }
        public List<Element> GetNodes()
        {
            var connector = GetStardogConnector();
            var query = "SELECT DISTINCT * {?child rdfs:subClassOf ?parent}";
            var result = (SparqlResultSet)connector.Query(query);
            var objects = new List<MyObject>();
            foreach (var r in result)
            {
                objects.Add(AssembleObject(r));
            }
            var parentUri = objects.Select(ob => ob.ParentUri).ToList();
            var childrenUri = objects.Select(ob => ob.Uri).ToList();
            parentUri.AddRange(childrenUri.Where(u => !parentUri.Contains(u)));
            var elements = parentUri.Select(el => new Element() { Uri = el,ParentUri=objects.FirstOrDefault(ob=>ob.Uri==el)?.ParentUri }).ToList();
            elements.ForEach(i => i.Children = elements.Where(ch => ch.ParentUri == i.Uri).ToList());
            elements = elements.Where(e => e.Children != null && e.Children.Count > 0).ToList();
            return elements;
        }


        private MyObject AssembleObject(SparqlResult result)
        {

            var concept = new MyObject
            {
                Uri = result["child"].ToString(),
                ParentUri=result["parent"].ToString()
            };
            return concept;
        }

        public class MyObject
        { 
            public string ParentUri { get; set; }
            public string Uri { get; set; }
        }

        public class Node
        {
            public List<Node> Children = new List<Node>();
            public Node Parent { get; set; }
            public MyObject AssociatedObject { get; set; }
        }

        public class Element
        {
            public List<Element> Children { get; set; }
            public string Uri { get; set; }
            public string ParentUri { get; set; }
        }

        List<Node> BuildTreeAndGetRoots(List<MyObject> actualObjects)
        {
            Dictionary<string, Node> lookup = new Dictionary<string, Node>();
            actualObjects.ForEach(x => lookup.Add(x.Uri, new Node { AssociatedObject = x }));
            foreach (var item in lookup.Values)
            {
                Node proposedParent;
                if (lookup.TryGetValue(item.AssociatedObject.ParentUri, out proposedParent))
                {
                    item.Parent = proposedParent;
                    proposedParent.Children.Add(item);
                }
            }
            return lookup.Values.Where(x => x.Parent == null).ToList();
        }
    }
}
