

/*
 * Plan and build a console application that asks a user for their name and their age. 
 * If their name is Bob or Sue, address them as Professor. If the person is under 21,
 * recommend they wait X years to start this class.
 * 
 */

// Ask a user for their name and their age.
Console.WriteLine("Entry your first name: ");
string? firstName = Console.ReadLine();
string lowerFirstName = firstName.ToLower();

Console.WriteLine("Enter your age: ");
int? age = int.Parse(Console.ReadLine());

//Console.WriteLine(lowerFirstName);
//Console.WriteLine(age);


// If their name is Bob or Sue, address them as Professor
// If the person is under 21 recommend to wait X years to start this class.

if ( lowerFirstName == "bob" || lowerFirstName == "sue")
{
    Console.WriteLine($"Welcome Professor {lowerFirstName}!");
}
else if ( age < 21 )
{
    Console.WriteLine($"We recommend to wait {21 - age} more years to start this class.");
}
else
{
    Console.WriteLine($"Welcome to the Class, {lowerFirstName}!");
}

