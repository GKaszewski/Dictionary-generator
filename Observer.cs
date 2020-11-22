namespace Dictionary_Generator
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }
}
