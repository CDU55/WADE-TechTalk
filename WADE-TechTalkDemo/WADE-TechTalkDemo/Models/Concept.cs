using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WADE_TechTalkDemo.Models
{
    public class Concept
    {
        public string Uri { get; set; }
        public string PrefLabelEng { get; set; }
        public string PrefLabelDe { get; set; }
        public List<Concept> Broader { get; set; }
        public List<Concept> Narrower { get; set; }
        public List<Concept> Related { get; set; }

        public Concept()
        {
            Broader = new List<Concept>();
            Narrower = new List<Concept>();
            Related = new List<Concept>();
        }
    }
}
