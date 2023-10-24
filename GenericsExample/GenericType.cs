namespace GenericsExample;

public class GenericType<TInterface, TAnother> : IGenericInterfaceWithTypeConstraints<TInterface, TAnother>
    where TInterface : ISomeInterface
    where TAnother : IAnotherInterface
{
    public void Handle(TInterface inSome)
    {
        
    }

    public TAnother HandleWithReturn(TInterface inSome, string inStr) 
    {
        return (TAnother)inSome.DoSomething(inStr);
    }
}