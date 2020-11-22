using Newtonsoft.Json;
using System.Collections.Generic;

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
        public static List<Word> WordsFromJSON(string content)
        {
            var words = new List<Word>();
            var result = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(content);
            foreach (var wordDict in result)
            {
                var newWord = new Word(wordDict["Spanish"], wordDict["English"]);
                words.Add(newWord);
            }
            return words;
        }

        public static string WordsToJSON(List<Word> data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

    }
}
