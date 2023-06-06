
using System;
using System.Collections.Generic;

// Number 1


{
    // Defining a list of lists, where each inner list represents a set of numbers
    List<List<int>> lists = new List<List<int>>
        {
            new List<int> { 1, 5, 3 },
            new List<int> { 9, 7, 3, -2 },
            new List<int> { 2, 1, 2 }
        };

    // Calling the MaxNumbersInLists method to find the maximum numbers in each list
    List<int> maxNumbers = MaxNumbersInLists(lists);
    for (int i = 0; i < maxNumbers.Count; i++)
    {
        Console.WriteLine($"List {i + 1} has a maximum of {maxNumbers[i]}.");
    }
}

    List<int> MaxNumbersInLists(List<List<int>> lists)
{
    // Creating a list to store the maximum numbers
    List<int> maxNumbers = new List<int>();

    foreach (List<int> list in lists)
    {
        if (list.Count > 0)
        {
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            maxNumbers.Add(max);
        }
    }

    return maxNumbers;
}

Console.WriteLine();
// Time complexity is O(n).



// Number 2


string HighestGrade(List<List<int>> courses)
{
    if (courses == null || courses.Count == 0)
    {
        return "No courses found.";
    }

    int maxGrade = int.MinValue;
    List<int> maxIndices = new List<int>();

    for (int i = 0; i < courses.Count; i++)
    {
        List<int> grades = courses[i];

        // Check if the list of grades is not null and has at least one grade
        if (grades != null && grades.Count > 0)
        {
            foreach (int grade in grades)
            {
                // Update the maximum grade and clear the maxIndices list if a higher grade is found
                if (grade > maxGrade)
                {
                    maxGrade = grade;
                    maxIndices.Clear();
                    maxIndices.Add(i);
                }
                else if (grade == maxGrade)
                {
                    maxIndices.Add(i);
                }
            }
        }
    }

    if (maxIndices.Count == 0)
    {
        return "No grades found.";
    }

    string result = $"The highest grade is {maxGrade}. This grade was found in class {string.Join(", ", maxIndices)}.";
    return result;
}

List<List<int>> courses = new List<List<int>>
{
    new List<int> { 90, 85, 92 },
    new List<int> { 78, 88, 82 },
    new List<int> { 94, 91, 95 }
};

string result = HighestGrade(courses);
Console.WriteLine(result);
Console.WriteLine();
// Time complexity is O(n).




// Number 3


static List<int> OrderByLooping(List<int> numbers)
{
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        for (int j = 0; j < numbers.Count - i - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }

    return numbers;
}

List<int> numbers = new List<int> { 6, -2, 5, 3 };
List<int> orderedNumbers = OrderByLooping(numbers);

Console.WriteLine("Ordered numbers: " + string.Join(", ", orderedNumbers));
// Time complexity is O(n^2).
