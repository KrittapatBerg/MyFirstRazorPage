using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public interface ICoolLists
    {
        public List<LatinSentence> LatinSentences { get; set; }
        public List<Quote> NiceQuotes { get; set; }
    }
    public class CoolList : ICoolLists
    {
        public List<LatinSentence> LatinSentences { get; set; }
        public List<Quote> NiceQuotes { get; set; }

        public CoolList() 
        {
            var seeder = new csSeedGenerator();
            LatinSentences = seeder.LatinSentences(50).Select(s => new LatinSentence() 
                { Sentence = s }).ToList();
            NiceQuotes = seeder.AllQuotes.Select(q => new Quote() { NiceQuotes = q.Quote, Author = q.Author }).ToList();
        }
    }
}
