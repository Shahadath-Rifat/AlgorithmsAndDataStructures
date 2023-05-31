

using System;
using System.Text.RegularExpressions;


//prompt user for integer n, which serves as array length of word list 

int n = 0;

while (n <= 0)

{ //form validation

    Console.WriteLine("please enter integer value greater than zero ");

    n = Int32.Parse(Console.ReadLine());
}




string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Please enter word {i + 1}:");
    string newWord = Console.ReadLine();

    if (IsValidWord(newWord))
    {
        words[i] = newWord.ToLower();
    }
    else
    {
        Console.WriteLine("Sorry, you must enter at least one character, with no spaces, numbers, or special characters in the word.");
        i--;
    }
}

Console.WriteLine();

Console.WriteLine("The words you entered are:");
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}

static bool IsValidWord(string word)
{
    // Check if the word contains only letters (no numbers or special characters)
    return Regex.IsMatch(word, @"^[a-zA-Z]+$");
}


// Initialize character as space so you are prompted to enter a character.
char charToCount = ' ';


while (!Char.IsLetter(charToCount))
{
    Console.WriteLine("Please enter a character");
    charToCount = Char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
}
Console.WriteLine($"\nYou entered '{charToCount}'");

// get a count of how many times this character appears in all of the words
int charCount = 0;
int totalCharCount = 0;

foreach (string word in words)
{
    char[] chars = word.ToCharArray();

    foreach (char c in chars)
    {
        if (c == charToCount)
        {
            charCount++;
        }
        totalCharCount++;
    }
}


if ((charCount * 100) / totalCharCount > 25)
{
    Console.WriteLine($"The letter '{charToCount}' appears {charCount} times in the array. " +
        $"And this letter makes up more than 25 % of the total number of characters.");
}
else
{
    Console.WriteLine($"The letter {charToCount} appears {charCount} times in the array." +
        $"And this letter makees less than 25% of the total number of characters.");
}


/*
 
The choice of the numeric data type depends on the expected range and precision of the total count of letters
you want to store. If the count of letters can be reasonably represented within the range of a standard numeric
data type, such as int or long, it is generally more efficient to use those data types.
 
However, if the count of letters can exceed the range of standard numeric data types, or if you require arbitrary 
precision for very large counts, using BigInteger would be a suitable choice.  Since it deals with arbitrary precision,
operations on BigInteger can be slower compared to standard numeric data types. If your count of letters doesn't exceed 
the range of standard data types, using BigInteger might introduce unnecessary overhead.
 
 */









