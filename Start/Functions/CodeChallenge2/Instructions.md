# Test a string to see if it is a palindrome
You're given a string.

**Your task**: Determine whether the string is a palindrome based upon these rules:
- A palindrome reads the same both forward and backward, regardless of letter case.
- Examples: "Radar" and "Rotor" are both palindromes.
- You must also ignore spaces and punctuation.
- Examples: "Race car!" and "Madam, I'm Adam" are also palindromes.

# Parameters
`teststring`: The string to test for palindrome

# Result
`Boolean`: True if the string is a palindrome; otherwise, false

# Constraints
- The `teststr` argument always contains a non-empty string.

# Example 1:
Input: `"Radar!"`
Result: `true`

# Example 2:
Input: `"Hello World!"`
Result: `false`

# Want a hint?
The StringBuilder class will come in handy. Also, take a look at the IsPunctuationO
and IsWhiteSpace() functions in the .NET documentation.