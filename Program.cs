//We define the usage of capitals in a word to be right when one of the following cases holds:

//All letters in this word are capitals, like "USA".
//All letters in this word are not capitals, like "leetcode".
//Only the first letter in this word is capital, like "Google".
//Given a string word, return true if the usage of capitals in it is right.

//Example 1:

//Input: word = "USA"
//Output: true
//Example 2:

//Input: word = "FlaG"
//Output: false

//Constraints:

//1 <= word.length <= 100
//word consists of lowercase and uppercase English letters.


using System;
using System.Linq;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (word.Length < 1 || word.Length > 100)
            throw new ArgumentException("O comprimento da palavra deve estar entre 1 e 100 caracteres.");

        if (!word.All(char.IsLetter))
            throw new ArgumentException("A palavra deve conter apenas letras maiúsculas e minúsculas do alfabeto inglês.");

        return word.All(char.IsUpper) || word.All(char.IsLower) ||
               (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower));
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.DetectCapitalUse("USA")); 
        Console.WriteLine(solution.DetectCapitalUse("FlaG"));
    }
}
