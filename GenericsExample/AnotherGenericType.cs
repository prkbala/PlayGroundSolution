namespace GenericsExample;

public class AnotherGenericType : IGenericInterface
{
    public void Handle<TSome>()
    {
    }

    public void Handle<TSome>(TSome s) where TSome : ISomeInterface
    {
        s.DoSomething("test");
    }

    public TAnother HandleWithReturn<TAnother, TSome>(TSome s) 
        where TAnother : IAnotherInterface 
        where TSome : ISomeInterface
    {
        return (TAnother)s.DoSomething("with return");
    }
}