

using System;
using System.Collections.Generic;

// Number 01



{
    {
        int[] numbers = { 1, 2, 3, 4, 7, 9, 2, 4 };
        // Calling the FindDuplicates method to find the duplicate numbers
        List<int> duplicates = FindDuplicates(numbers);

        Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
    }

    // FindDuplicates method to identify duplicate numbers in the input array
    List<int> FindDuplicates(int[] numbers)
    {
       
        List<int> duplicates = new List<int>();  // Create a list to store the duplicate numbers
        HashSet<int> uniqueNumbers = new HashSet<int>();    // Create a HashSet to store unique numbers encountered

        foreach (int num in numbers)
        {
            if (!uniqueNumbers.Contains(num))
            {
                uniqueNumbers.Add(num);
            }
            else
            {
                duplicates.Add(num);
            }
        }

        return duplicates;
    }
}

Console.WriteLine();



// Number 02




{
    // MergeSortedArrays method to merge two sorted arrays into a single sorted array
    static int[] MergeSortedArrays(int[] arr1, int[] arr2) 
    {
        int size1 = arr1.Length;
        int size2 = arr2.Length;
        int[] merged = new int[size1 + size2]; // Creating a new array to store the merged result
        int i = 0;
        int j = 0;
        int k = 0;

        // Comparing elements from both arrays and fill the merged array in sorted order
        while (i < size1 && j < size2)
        {
            if (arr1[i] <= arr2[j])
            {      
                // If the current element in arr1 is smaller or equal, add it to the merged array
                merged[k] = arr1[i];
                i++;
            }
            else
            {
                merged[k] = arr2[j];
                j++;
            }
            k++;
        }

        while (i < size1)
        {
            merged[k] = arr1[i];
            i++;
            k++;
        }

        while (j < size2)
        {
            merged[k] = arr2[j];
            j++;
            k++;
        }

        return merged;
    }

   
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 2, 5, 7, 9, 13 };
        int[] result = MergeSortedArrays(arr1, arr2);

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();





// Number 03



{
    int num = 96731638;
    int reversed = 0;

    while (num != 0)
    {
        // Extracting the last digit of the number
        int digit = num % 10;

        // Add the digit to the reversed number by multiplying it by 10 and adding the digit
        reversed = (reversed * 10) + digit;

        // Remove the last digit from the inputed number
        num /= 10;
    }

    Console.WriteLine("Reversed Number: " + reversed);
}
// the overall time complexity of this solution is O(n).

