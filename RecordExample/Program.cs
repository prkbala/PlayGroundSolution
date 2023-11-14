
// When to use records

// Consider using a record in place of a class or struct in the following scenarios:
    // - You want to define a data model that depends on value equality.
    // - You want to define a type for which objects are immutable.

var bala = new Person ("Bala", new DateOnly(1985, 8, 13));

// Prints the parameters by default
Console.WriteLine(bala);

var arjun = bala with { Name = "Arjun"};
Console.WriteLine(arjun);


var anotherInstanceBala = new Person("Bala", new DateOnly(1985, 8, 13));
// Returns True. Equality checks for the value of the params and not the reference, unlike in class
Console.WriteLine(bala.Equals(anotherInstanceBala));

public record Person(string Name, DateOnly DateOfBirth);
