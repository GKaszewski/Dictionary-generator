using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Generator.Data
{
    public class AppSettings
    {
        private AppSettings(){}
        #region SINGLETON
        private static AppSettings _instance;
        public static AppSettings Instance => _instance ?? (_instance = new AppSettings());
        #endregion
        public string Path;
        public List<Word> Words = new List<Word>();
    }
}
