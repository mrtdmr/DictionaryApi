using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApi.Model
{
    public class Meaning
    {
        public int Id { get; set; }
        public string Turkish { get; set; }
        public string English { get; set; }
        public string Sentence { get; set; }
        public int WordId { get; set; }
        public Word Word { get; set; }
    }
}
