
using System;

// Number- 01


{
    string input = "Programmatic Python";
    char[] characters = input.ToCharArray(); // Convert the input string to a character array
    char[] duplicates = new char[characters.Length]; // Creating an array to store duplicate characters
    int count = 0;

    for (int i = 0; i < characters.Length; i++)
    {
        bool isDuplicate = false;

        // Compare each character with the other characters to find duplicates
        for (int j = i + 1; j < characters.Length; j++)
        {
            if (characters[i] == characters[j])
            {
                isDuplicate = true;
                break;  // If a duplicate is found, set it and break the loop
            }
        }
        // If the character is a duplicate and not already added to the duplicates array
        if (isDuplicate && Array.IndexOf(duplicates, characters[i]) == -1)
        {
            duplicates[count++] = characters[i];
        }
    }
    // here, ref keyword make sure the resize operation modifies the original array itself.
    Array.Resize(ref duplicates, count); // Resize the duplicates array to remove unused elements

    Console.WriteLine(string.Join(",", duplicates));
}

Console.WriteLine();





// Number-02


{
    string input = "To be or not to be";
    //  By using StringSplitOptions.RemoveEmptyEntries, any empty entries (empty words) will be removed from the resulting array.
    string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string[] uniqueWords = new string[words.Length];
    int count = 0;

    for (int i = 0; i < words.Length; i++)
    {
        bool isUnique = true;

        for (int j = 0; j < count; j++)
        {      
            //  Here, StringComparison.OrdinalIgnoreCase will make sure words with different capitalization will be considered same.
            if (string.Equals(words[i], uniqueWords[j], StringComparison.OrdinalIgnoreCase))
            {
                isUnique = false;
                break;
            }
        }

        if (isUnique)
        {
            uniqueWords[count] = words[i];
            count++;
        }
    }

    Array.Resize(ref uniqueWords, count);

    Console.WriteLine("Unique words in the string:");
    Console.WriteLine(string.Join(", ", uniqueWords));
}

Console.WriteLine();





// Number-03


{
    string input = "Hey there, This is Shahadath Hussain Rifat, a student at MITT";

    char[] characters = input.ToCharArray();

    // Reverse the order of the characters in the array
    Array.Reverse(characters);

    string result = new string(characters);
    Console.WriteLine(result);
}

Console.WriteLine();





// Number-04


{
    string input = "Tiptoe through the tulips";
    string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string longestWord = ""; // Initializing the variable to store the longest word

    foreach (string word in words)
    { 
        if (word.Length > longestWord.Length)  // Checking if the current word is longer than the current longest word
        {
            longestWord = word;
        }
    }

    Console.WriteLine(longestWord);
}




/* 
  The StringBuilder class in C# is a mutable string representation. Here is the merit and demerit of stringBuilder in compare to string:

    Advantages: 1) We can modify them directly. It gives added advantages while perform repeated string
                manipulation operations, as it avoids overhead of creating new strings with each concatenation.
                2) StringBuilder supports method chaining, allowing you to perform multiple operations
                   sequentially without the need for separate statements

    Disadvantages: 1) For operations like searching, replacing, or pattern matching, using the string class 
                       or regular expressions might be more appropriate because StringBuilder does not offer
                       the full range of string operations available with the string class.
*/

