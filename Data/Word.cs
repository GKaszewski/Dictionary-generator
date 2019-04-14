using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Generator.Data
{
    public class Word
    {
        public string Spanish { get; }
        public string English { get; }

        public Word(string spanish, string english)
        {
            Spanish = spanish;
            English = english;
        }

        public Dictionary<string, string> ToDictionary()
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Spanish", Spanish);
            dictionary.Add("English", English);
            return dictionary;
        }
    }
}
