using System.Collections.Generic;

namespace Dictionary_Generator.Data
{
    public class WordList : ISubject
    {
        private List<IObserver> observers;
        private List<Word> words;
        public List<Word> Words 
        { 
            get { return words; }
            set
            {
                words = value;
                Notify();
            }
        }

        public WordList()
        {
            observers = new List<IObserver>();
            words = new List<Word>();
        }

        public void Attach(IObserver observer)
        {
            if (!observers.Contains(observer)) observers.Add(observer);
        }

        public void Notify()
        {
            observers.ForEach(o =>
            {
                o.Update(this);
            });
        }

        public void Detach(IObserver observer)
        {
            if (observers.Contains(observer)) observers.Remove(observer);
        }
    }
}
