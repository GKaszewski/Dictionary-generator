using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Dictionary_Generator.Data;
using File = System.IO.File;

namespace Dictionary_Generator
{
    public partial class GeneratorWindow : Form
    {
        private const string PATH = "settings.txt";

        public GeneratorWindow()
        {
            InitializeComponent();
            AppSettings.Instance.state.onWordsChanged += OnWordsChanged;
        }

        private void OnWordsChanged()
        {
            UpdateGrids();
        }

        private void UpdateGrids()
        {
            csvDataGrid.DataSource = AppSettings.Instance.state.words.Words;
            jsonDataGrid.DataSource = AppSettings.Instance.state.words.Words;
        }

        private void GeneratorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var writer = new StreamWriter(PATH)) writer.Write(AppSettings.Instance.Path);
        }

        private void GeneratorWindow_Load(object sender, EventArgs e)
        {
            if (!File.Exists(PATH)) return;

            ReadPathFromSettingsFile();

            UpdateTitle();
        }

        private static void ReadPathFromSettingsFile()
        {
            using (var reader = new StreamReader(PATH))
            {
                AppSettings.Instance.Path = reader.ReadLine();
            }
        }

        private void ExportToJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateJSONFile();
            if (ReadJSONFileAndCheckIfEmpty())
                PutData();

            SaveData();
        }

        private void SaveData()
        {
            using (var writer = new StreamWriter(AppSettings.Instance.Path)) writer.Write(Word.WordsToJSON(AppSettings.Instance.state.words.Words));
        }

        private void PutData()
        {
            using (var reader = new StreamReader(AppSettings.Instance.Path))
            {
                var newData = new List<Word>();
                var previousData = Word.WordsFromJSON(reader.ReadToEnd());
                foreach (var word in previousData) newData.Add(word);
                foreach (var word in AppSettings.Instance.state.words.Words) newData.Add(word);
                AppSettings.Instance.state.words.Words = newData;
            }
        }

        private bool ReadJSONFileAndCheckIfEmpty()
        {
            if (File.Exists(AppSettings.Instance.Path))
            {
                using (var reader = new StreamReader(AppSettings.Instance.Path))
                {
                    var data = reader.ReadToEnd();
                    return !string.IsNullOrEmpty(data);
                }
            }

            return false;
        }

        private void CreateJSONFile()
        {
            if (!string.IsNullOrEmpty(AppSettings.Instance.Path))
                return;

            if (exportJSONDialog.ShowDialog() == DialogResult.OK)
            {
                AppSettings.Instance.Path = exportJSONDialog.FileName;
                var file = File.Create(AppSettings.Instance.Path);
                file.Close();
            }
            UpdateTitle();
        }

        private void ChangePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exportJSONDialog.ShowDialog() == DialogResult.OK)
                AppSettings.Instance.Path = exportJSONDialog.FileName;

            UpdateTitle();
        }

        private void UpdateTitle() => Text += " Path: " + AppSettings.Instance.Path;

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (openFileDialog.FilterIndex)
                {
                    case (int)FileType.JSON:
                        Utility.OpenJSONFile(openFileDialog.FileName);
                        break;
                    case (int)FileType.CSV:
                        Utility.OpenCSVFile(openFileDialog.FileName);
                        break;
                }
            }
        }
    }
}
