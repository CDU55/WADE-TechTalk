using System;
using System.Linq;
using Wade_TechTalk.Stardog.Services;

namespace TestEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ThesauriService("http://localhost:5820", "Thesaurus","admin","admin");
            var result=service.GetAll().GroupBy(s=>s.Uri).Where(g=>g.Count()>1);
            Console.ReadLine();
        }
    }
}
