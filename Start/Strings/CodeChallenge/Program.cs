// C# code​​​​​​‌‌​​‌​​​‌​‌‌‌‌‌‌​​‌​‌​​‌‌ below
using System;

// Write your answer here, and then test your code.
// Your job is to implement the findLargest() method.

public class Answer {
    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public  static Boolean ShowExpectedResult = false;
    public  static Boolean ShowHints = false;

    public static bool CountTheType(object Arg, string TypeToCount) {
        // Your code goes here. Return true if the type of the Arg is the same
        // as what the TypeToCount parameter says to count.
        String objectType = Arg.GetType().ToString();

        if (objectType.Equals(TypeToCount))
        {
            return true;
        }
        
        return false;
    }

    static void Main(string[] args) {
        // This is how your code will be called.
        // You can edit this code to try different testing cases.
        object[] items = {1, 2, "Hello!", "World", 'X', true, 2.0, ".NET", 'A'};
        int total = 0;
        string CountType = "System.String";

        foreach (object item in items) {
            if (Answer.CountTheType(item, CountType)) {
                total++;
            }
        }
        // Expected result is 3
        Console.WriteLine(total);
    }
}
