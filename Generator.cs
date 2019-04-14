using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dictionary_Generator.Data;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using File = System.IO.File;

namespace Dictionary_Generator
{
    public partial class GeneratorWindow : Form
    {
        private string path = "settings.txt";
        private List<Word> words = new List<Word>();

        public GeneratorWindow()
        {
            InitializeComponent();
        }

        private void GeneratorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var writer = new StreamWriter(path)) writer.Write(AppSettings.Instance.Path);
        }

        private void GeneratorWindow_Load(object sender, EventArgs e)
        {
            if (!File.Exists(path)) return;

            using (var reader = new StreamReader(path))
            {
                AppSettings.Instance.Path = reader.ReadLine();
            }

            UpdateTitle();
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            var word = new Word(spanishTextBox.Text, englishTextBox.Text);
            AppSettings.Instance.Words.Add(word);
        }

        private void exportToJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppSettings.Instance.Path))
            {
                if (exportJSONDialog.ShowDialog() == DialogResult.OK)
                {
                    AppSettings.Instance.Path = exportJSONDialog.FileName;
                    File.Create(AppSettings.Instance.Path);
                }
                UpdateTitle();
            }

            var hasData = false;

            if (File.Exists(AppSettings.Instance.Path))
            {
                using (var reader = new StreamReader(AppSettings.Instance.Path))
                {
                    var data = reader.ReadToEnd();
                    hasData = !string.IsNullOrEmpty(data);
                } 
            }

            if (hasData)
            {
                using (var reader = new StreamReader(AppSettings.Instance.Path))
                {
                    var newData = new List<Word>();
                    var previousData = WordsFromJSON(reader.ReadToEnd());
                    foreach (var word in previousData) newData.Add(word);
                    foreach (var word in AppSettings.Instance.Words) newData.Add(word);
                    AppSettings.Instance.Words = newData;
                }
            }

            var jsonData = JsonConvert.SerializeObject(AppSettings.Instance.Words, Formatting.Indented);
            using (var writer = new StreamWriter(AppSettings.Instance.Path)) writer.Write(jsonData);
            jsonDataGrid.DataSource = AppSettings.Instance.Words;
        }

        private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exportJSONDialog.ShowDialog() == DialogResult.OK)
                AppSettings.Instance.Path = exportJSONDialog.FileName;

            UpdateTitle();
        }

        private void UpdateTitle() => Text += " Path: " + AppSettings.Instance.Path;

        private List<Word> WordsFromJSON(string content)
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

        private string openJSONFile(string path)
        {
            using (var reader = new StreamReader(path))
                return reader.ReadToEnd();
        }

        private void openCSVFile(string path)
        {
            using (var parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    var fields = parser.ReadFields();
                    var newWord = new Word(fields[0], fields[1]);
                    words.Add(newWord);
                    //var data = WordsFromCSV(fields);
                }
            }

            csvDataGrid.DataSource = words;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog.FilterIndex)
                {
                    case 1:
                        var data = WordsFromJSON(openJSONFile(openFileDialog.FileName));
                        jsonDataGrid.DataSource = data;
                        break;
                    case 2:
                        openCSVFile(openFileDialog.FileName);
                        break;
                }
            }
        }

        private void addToDictButton_Click(object sender, EventArgs e)
        {
            foreach (var word in words) AppSettings.Instance.Words.Add(word);
        }
    }
}
