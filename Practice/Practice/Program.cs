// Practice C# From Beginning
// Data Types 
/* 
    1. Value Types
        - int, float, double, char, bool, decimal
    2. Reference Types
        - string, object, dynamic, array, class
    3. Nullable Types
        - int?, double?, bool?
    4. Tuples
        - (int, string)
    5. Enums
        - enum Days { Sun, Mon, Tue }
*/
// Int is a value type, and it stores the value directly in the memory allocated for the variable.
// String is a reference type, and it stores a reference to the memory location where the actual string data is stored.
// Float is a value type, and it stores the value directly in the memory allocated for the variable.

// byte variable_byte = 50;
// Console.WriteLine(variable_byte); // Output: 50
// sbyte signedByteVariable = -50;
// Console.WriteLine(signedByteVariable); // Output: -50
// short variable_short = 500;
// Console.WriteLine(variable_short); // Output: 500
// ushort unsignedShortVariable = 200;
// Console.WriteLine(unsignedShortVariable); // Output: 200
// long variable_long = 5000L;``
// Console.WriteLine(variable_long); // Output: 5000
// ulong unsignedLongVariable = 2000000000000000000UL;
// Console.WriteLine(unsignedLongVariable); // Output: 2000000000000000000

int employeeId = 20;
string companyName = "UTCLI";
Console.WriteLine("Hello, my employee ID is " + employeeId + " and my company name is " + companyName + ".");
Console.WriteLine("Hello, my employee ID is {0} and my company name is {1}.", employeeId, companyName);
Console.WriteLine($"Hello, my employee ID is {employeeId} and my company name is {companyName}.");