# Determine the type of piece of data
For this challenge, you will write some code that determines the type of an argument
that is passed to your function. In .NET, all data types are essentially objects and are
subclasses of the base `object` class.

You're given an argument of an arbitrary .NET data type and a string indicating what
type it should be tested against.

`public static bool YourFunction(object Arg, string TypeToCount)`

**Your task**: Return true if the `Arg` argument's type is the same as the `TypeToCount`
string description.
# Parameters
`Arg`: An object that will be one of: integer, char, string, double, or Boolean
`TypeToCount`: A string description of the type of interest
# Result
`bool`: True if the type of the Arg parameter matches the string that describes the
type; otherwise, false
# Constraints
- The `Arg` parameter is always one of: int, string, Boolean, double, or char.
- The `Arg` parameter is never empty.
# Example 1:
input: `"Hello", "System.String"`
Result: `true`
# Example 2:
input: `2.0, "System.Int32"`
Result: `false`
# Want a hint?
You can use the `GetType()` function to determine any object's type. For example:

object[] items ={1, "String", 'A'}
```
items[0].GetType().ToString() // returns "System.Int32 "
items[l].GetType().ToString() // returns "System.String"
items[2].GetType().ToString() // returns "System.Char"
```
The valid list of types to compare against are:
"System.lnt32", "System.String", "System.Boolean", "System.Double", "System.Char"