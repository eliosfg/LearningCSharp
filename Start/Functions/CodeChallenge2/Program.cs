// C# code​​​​​​‌‌​​‌​​​‌‌‌‌​‌‌​‌‌‌‌‌​‌​​ below
using System;
using System.Text;

// Write your answer here, and then test your code.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public  static Boolean ShowExpectedResult = false;
   public  static Boolean ShowHints = false;

    // Determine whether a string is a Palindrome
    public static bool IsPalindrome(string thestr) {
        StringBuilder mystr = new StringBuilder();

        foreach (char c in thestr)
        {
            if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c))
            {
                mystr.Append(Char.ToLower(c));
            }
        }
        
        String reverted = "";
        for (int i = mystr.Length - 1; i >= 0; i--)
        {
            reverted += mystr[i].ToString();
        }

        return (mystr.ToString() == reverted);
    }

    static void Main(string[] args)
    {
        // This is how your code will be called.
        // You can edit this code to try different testing cases.
        string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
        int palcount = 0;
        foreach (string str in teststrings) {
            bool learnerResult = IsPalindrome(str);
            if (learnerResult)
                Console.WriteLine("The string \"" + str + "\" is a palindrome.");
        }
    }

}
