
var instanceA = new A();

// Default ToString() example. Just prints 'A'
Console.WriteLine(instanceA.ToString());

var instanceAa = new A();

// Default Equals(). Returns false, because they are 2 different instances / references
Console.WriteLine(instanceA.Equals(instanceAa));


var instanceB = instanceA;
// Default Equals(). Returns true, because they are referring to the same instance
Console.WriteLine(instanceA.Equals(instanceB));

// ReferenceEquals(). Returns true, because they refer to the same instance. ReferenceEquals is static and not overridable
// which means you will always get a consistent response as it checks for reference only where as Equals is overridable and
// hence it can be written to do proper parameter equality by the class creator.
Console.WriteLine(object.ReferenceEquals(instanceA,instanceB));


var clonedInstance= instanceA.Clone();
// False, as expected
Console.WriteLine("Memberwise clones have different references as a copy is made. " + ReferenceEquals(instanceA, clonedInstance));
// True, because MemberwiseClone does a shallow copy and the references of properties matches
Console.WriteLine("MemberwiseClone does a shallow copy and the references of properties matches. " + ReferenceEquals(instanceA.test, clonedInstance.test));


public class A
{
    public int i = 0;
    public string test = "TestString";

    public A Clone()
    {
        return (A) MemberwiseClone();
    }
}
