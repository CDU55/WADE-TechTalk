using System;
using System.Collections.Generic;
using System.Text;

namespace Wade_TechTalk.Stardog.Models
{
    public class Concept
    {
        public string Uri { get; set; }
        public string PrefLabelEng { get; set; }
        public string PrefLabelDe { get; set; }
        public List<Concept> Broader { get; set; }
        public List<Concept> Narrower { get; set; }
        public List<Concept> Related { get; set; }
    }
}
