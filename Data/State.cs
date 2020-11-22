using System;

namespace Dictionary_Generator.Data
{
    public class State : IObserver
    {
        public WordList words;
        public event Action onWordsChanged;

        public State()
        {
            words = new WordList();
            words.Attach(this);
        }

        ~State()
        {
            words.Detach(this);
        }

        public void Update(ISubject subject)
        {
           if (subject is WordList wordList)
           {
                words = wordList;
                onWordsChanged?.Invoke();
           }
        }
    }
}
