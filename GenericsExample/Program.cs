// See https://aka.ms/new-console-template for more information

using GenericsExample;

Console.WriteLine("Hello, World!");

var genericObject = new GenericType<SomeType, AnotherType>();
genericObject.Handle(new SomeType());
var anotherType = genericObject.HandleWithReturn(new SomeType(), "Test Generics");
Console.WriteLine("Generics constraints worked");


var anotherGeneric = new AnotherGenericType();
var anotherReturn = anotherGeneric.HandleWithReturn<IAnotherInterface, ISomeInterface>(new SomeType());
Console.WriteLine("Generics without constraints worked");