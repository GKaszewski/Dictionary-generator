using System.Collections.Generic;
using System.IO;
using Dictionary_Generator.Data;
using Microsoft.VisualBasic.FileIO;

namespace Dictionary_Generator
{
    public class Utility
    {
        public static void OpenJSONFile(string path)
        {
            var words = new List<Word>();
            using (var reader = new StreamReader(path)) {
                var data = Word.WordsFromJSON(reader.ReadToEnd());
                words = data;
            }

            AppSettings.Instance.state.words.Words = words;
        }

        public static void OpenCSVFile(string path)
        {
            var words = new List<Word>();
            using (var parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    var newWord = new Word(fields[0], fields[1]);
                    words.Add(newWord);
                }
            }

            AppSettings.Instance.state.words.Words = words;
        }
    }
}
