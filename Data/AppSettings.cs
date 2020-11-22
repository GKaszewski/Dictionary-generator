namespace Dictionary_Generator.Data
{
    public class AppSettings
    {
        private AppSettings()
        {
            state = new State();
        }
        #region SINGLETON
        private static AppSettings _instance;
        public static AppSettings Instance => _instance ?? (_instance = new AppSettings());
        #endregion
        public string Path;
        public State state;
    }
}
