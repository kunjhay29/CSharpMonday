// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Globalization;

class Program
{
    static void Main()
    {

        // QUESTION 1
        // *********************************1*********************************  
        //Console.Write("Enter a number in the range of 1 and 10: ");
        //string input = Console.ReadLine();

        //if (int.TryParse(input, out int number) && number >= 1 && number <= 10)
        //{
        //    Console.WriteLine("Valid");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid");
        //}


        // *********************************2*********************************
        //Console.Write("Enter the first number: ");
        //string input1 = Console.ReadLine();

        //Console.Write("Enter the second number: ");
        //string input2 = Console.ReadLine();

        //if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
        //{
        //    int maxNumber = Math.Max(number1, number2);
        //    Console.WriteLine($"The maximum number is: {maxNumber}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter valid numbers.");
        //}


        // *********************************3*********************************
        //Console.Write("Enter the width of the image: ");
        //string widthInput = Console.ReadLine();

        //Console.Write("Enter the height of the image: ");
        //string heightInput = Console.ReadLine();

        //if (int.TryParse(widthInput, out int width) && int.TryParse(heightInput, out int height))
        //{
        //    if (width > height)
        //        Console.WriteLine("The image is in Landscape mode.");
        //    else if (width < height)
        //        Console.WriteLine("The image is in Portrait mode.");
        //    else
        //        Console.WriteLine("The image is Square.");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter valid numbers.");
        //}


        // *********************************4*********************************
        //// Prompt the user to enter the speed limit
        // Ask the user to enter the speed limit
        //Console.Write("Enter the speed limit: ");
        //int speedLimit = int.Parse(Console.ReadLine()); // Assume valid integer input

        //// Ask the user to enter the speed of the car
        //Console.Write("Enter the speed of the car: ");
        //int carSpeed = int.Parse(Console.ReadLine()); // Assume valid integer input

        //// If the car speed is within or below the limit, print "Ok"
        //if (carSpeed <= speedLimit)
        //{
        //    Console.WriteLine("Ok");
        //}
        //else
        //{
        //    // Calculate demerit points (1 point per 5 km/h over the limit)
        //    int demeritPoints = (carSpeed - speedLimit) / 5;
        //    Console.WriteLine($"Demerit Points: {demeritPoints}");

        //    // If demerit points exceed 12, suspend the license
        //    if (demeritPoints > 12)
        //    {
        //        Console.WriteLine("License Suspended");
        //    }
        //}




        // QUESTION 2
        // *********************************1*********************************
        //int count = 0; // Variable to store the count of numbers divisible by 3

        //// Loop through numbers from 1 to 100
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 3 == 0) // Check if the number is divisible by 3
        //    {
        //        count++; // Increment the count
        //    }
        //}

        //// Display the total count of numbers divisible by 3
        //Console.WriteLine($"Count of numbers divisible by 3 between 1 and 100: {count}");



        // *********************************2*********************************
        //int sum = 0; // Variable to store the sum of entered numbers

        //while (true) // Infinite loop until user enters "ok"
        //{
        //    Console.Write("Enter a number (or type 'ok' to exit): ");
        //    string input = Console.ReadLine();

        //    if (input.ToLower() == "ok") // Check if user wants to exit
        //    {
        //        break; // Exit the loop
        //    }

        //    sum += int.Parse(input); // Assume valid number input and add to sum
        //}

        //// Display the total sum after the user exits
        //Console.WriteLine($"Total sum of entered numbers: {sum}");



        // *********************************3*********************************

        // Ask the user to enter a number
        //Console.Write("Enter a number to compute its factorial: ");
        //int number = int.Parse(Console.ReadLine()); // Assume valid integer input

        //int factorial = 1; // Initialize factorial variable

        //// Loop from the number down to 1 to calculate factorial
        //for (int i = number; i > 1; i--)
        //{
        //    factorial *= i; // Multiply current factorial value by i
        //}

        //// Display the result in factorial format
        //Console.WriteLine($"{number}! = {factorial}");



        // *********************************4*********************************
        //Random random = new Random();
        //int secretNumber = random.Next(1, 11); // Generates a random number between 1 and 10

        //Console.WriteLine($"(Secret number: {secretNumber})"); // Debugging (Remove in real game)

        //int attempts = 4; // User gets 4 attempts

        //for (int i = 0; i < attempts; i++)
        //{
        //    Console.Write("Guess the number (1-10): ");
        //    int guess = int.Parse(Console.ReadLine()); // Assume valid integer input

        //    if (guess == secretNumber)
        //    {
        //        Console.WriteLine("You won!");
        //        return; // Exit the program since the user guessed correctly
        //    }
        //}

        //Console.WriteLine("You lost!");



        //*********************************5*********************************
        // Ask the user to enter numbers separated by commas
        //Console.Write("Enter a series of numbers separated by commas: ");
        //string input = Console.ReadLine(); // Read user input as a string

        //// Convert the input string into an array of integers
        //int[] numbers = input.Split(',').Select(int.Parse).ToArray();

        //// Find the maximum number in the array
        //int maxNumber = numbers.Max();

        //// Display the maximum number
        //Console.WriteLine($"The maximum number is: {maxNumber}");



        //QUESTION 3

        // *********************************1*********************************
        //List<string> names = new List<string>(); // List to store names

        //while (true)
        //{
        //    Console.Write("Enter a name (or press Enter to finish): ");
        //    string name = Console.ReadLine();

        //    if (string.IsNullOrWhiteSpace(name)) // Stop if input is empty
        //        break;

        //    names.Add(name); // Add name to the list
        //}

        //// Display message based on the number of likes
        //if (names.Count == 1)
        //{
        //    Console.WriteLine($"{names[0]} likes your post.");
        //}
        //else if (names.Count == 2)
        //{
        //    Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        //}
        //else if (names.Count > 2)
        //{
        //    Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
        //}


        // *********************************2*********************************
        //Console.Write("Enter your name: ");
        //string name = Console.ReadLine(); // Assume valid name input

        //// Convert the name to a character array
        //char[] nameArray = name.ToCharArray();

        //// Reverse the array
        //Array.Reverse(nameArray);

        //// Convert the reversed array back to a string
        //string reversedName = new string(nameArray);

        //// Display the reversed name
        //Console.WriteLine("Reversed Name: " + reversedName);

        // *********************************3*********************************

        //HashSet<int> numbers = new HashSet<int>(); // To store unique numbers
        //while (numbers.Count < 5)
        //{
        //    Console.Write($"Enter a unique number ({numbers.Count + 1}/5): ");
        //    if (int.TryParse(Console.ReadLine(), out int num))
        //    {
        //        if (numbers.Contains(num))
        //        {
        //            Console.WriteLine("Error: Number already entered. Try again.");
        //        }
        //        else
        //        {
        //            numbers.Add(num);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //    }
        //}

        //// Convert HashSet to list, sort, and display the numbers
        //List<int> sortedNumbers = new List<int>(numbers);
        //sortedNumbers.Sort();

        //Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));


        // *********************************4*********************************


        //HashSet<int> uniqueNumbers = new HashSet<int>(); // Stores unique numbers

        //while (true)
        //{
        //    Console.Write("Enter a number (or type 'Quit' to exit): ");
        //    string input = Console.ReadLine();

        //    if (input.Equals("Quit", StringComparison.OrdinalIgnoreCase)) // Check for exit condition
        //        break;

        //    if (int.TryParse(input, out int number)) // Convert input to integer
        //    {
        //        uniqueNumbers.Add(number); // Add to HashSet (automatically removes duplicates)
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //    }
        //}

        //// Display unique numbers
        //Console.WriteLine("Unique Numbers: " + string.Join(", ", uniqueNumbers));


        // *********************************5*********************************

        //while (true)
        //{
        //    Console.Write("Enter at least 5 comma-separated numbers (e.g., 5,1,9,2,10): ");
        //    string input = Console.ReadLine();

        //    // Split input by commas and convert to a list of integers
        //    List<int> numbers = input.Split(',')
        //                             .Select(num => num.Trim()) // Remove spaces
        //                             .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
        //                             .Select(int.Parse) // Convert to integers
        //                             .ToList();

        //    // Validate the input
        //    if (numbers.Count < 5)
        //    {
        //        Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
        //    }
        //    else
        //    {
        //        // Sort and take the smallest 3 numbers
        //        numbers.Sort();
        //        List<int> smallestNumbers = numbers.Take(3).ToList();

        //        Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
        //        break; // Exit the loop after successful input
        //    }
        //}


        // Question 4
        // *********************************1*********************************

        //Console.Write("Enter numbers separated by a hyphen (e.g., 5-6-7-8-9): ");
        //string input = Console.ReadLine();

        //// Convert input into a list of integers
        //List<int> numbers = input.Split('-')
        //                         .Select(num => num.Trim()) // Remove spaces
        //                         .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
        //                         .Select(int.Parse) // Convert to integers
        //                         .ToList();

        //// Check if the numbers are consecutive
        //bool isConsecutive = true;
        //for (int i = 1; i < numbers.Count; i++)
        //{
        //    if (Math.Abs(numbers[i] - numbers[i - 1]) != 1) // Difference must be 1
        //    {
        //        isConsecutive = false;
        //        break;
        //    }
        //}

        //// Display the result
        //Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");


        // *********************************2*********************************

        //Console.Write("Enter numbers separated by a hyphen (or press Enter to exit): ");
        //string input = Console.ReadLine();

        //// Exit if the user presses Enter without input
        //if (string.IsNullOrWhiteSpace(input))
        //    return;

        //// Convert input into a list of integers
        //List<int> numbers = input.Split('-')
        //                         .Select(num => num.Trim()) // Remove spaces
        //                         .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
        //                         .Select(int.Parse) // Convert to integers
        //                         .ToList();

        //// Check for duplicates using a HashSet
        //HashSet<int> uniqueNumbers = new HashSet<int>();
        //bool hasDuplicate = numbers.Any(num => !uniqueNumbers.Add(num));

        //// Display result
        //Console.WriteLine(hasDuplicate ? "Duplicate" : "No Duplicates");


        // *********************************3*********************************

        //Console.Write("Enter a time in 24-hour format (HH:mm): ");
        //string input = Console.ReadLine();

        //// Validate input format
        //if (string.IsNullOrWhiteSpace(input) || !TimeSpan.TryParse(input, out TimeSpan time))
        //{
        //    Console.WriteLine("Invalid Time");
        //    return;
        //}

        //// Extract hours and minutes
        //int hours = time.Hours;
        //int minutes = time.Minutes;

        //// Validate range (00:00 to 23:59)
        //if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
        //    Console.WriteLine("Ok");
        //else
        //    Console.WriteLine("Invalid Time");


        // *********************************4*********************************

        //Console.Write("Enter words separated by spaces: ");
        //string input = Console.ReadLine();

        //// Check if input is empty
        //if (string.IsNullOrWhiteSpace(input))
        //{
        //    Console.WriteLine("Invalid input.");
        //    return;
        //}

        //// Convert input into PascalCase
        //TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        //string pascalCase = string.Join("", input.Split(' ')
        //                                         .Where(word => !string.IsNullOrWhiteSpace(word)) // Remove empty entries
        //                                         .Select(word => textInfo.ToTitleCase(word.ToLower()))); // Capitalize first letter

        //Console.WriteLine("PascalCase Variable Name: " + pascalCase);


        // *********************************5*********************************

        //Console.Write("Enter an English word: ");
        //string input = Console.ReadLine();

        //// Check for empty input
        //if (string.IsNullOrWhiteSpace(input))
        //{
        //    Console.WriteLine("Invalid input.");
        //    return;
        //}

        //// Define vowels and count occurrences in input
        //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        //int vowelCount = input.ToLower().Count(c => vowels.Contains(c));

        //Console.WriteLine("Number of vowels: " + vowelCount);

        // Question 5
        // *********************************1*********************************


        //Console.Write("Enter the file path: ");
        //string filePath = Console.ReadLine();

        //// Check if file exists
        //if (!File.Exists(filePath))
        //{
        //    Console.WriteLine("File not found.");
        //    return;
        //}

        //try
        //{
        //    // Read the file content
        //    string text = File.ReadAllText(filePath);

        //    // Split words by whitespace and count them
        //    int wordCount = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

        //    Console.WriteLine("Number of words: " + wordCount);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error reading the file: " + ex.Message);
        //}


        // *********************************2*********************************

        //Console.Write("Enter the file path: ");
        //string filePath = Console.ReadLine();

        //// Check if file exists
        //if (!File.Exists(filePath))
        //{
        //    Console.WriteLine("File not found.");
        //    return;
        //}

        //try
        //{
        //    // Read the file content
        //    string text = File.ReadAllText(filePath);

        //    // Split words using non-letter characters as delimiters
        //    string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        //    // Find the longest word
        //    string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();

        //    Console.WriteLine("Longest word: " + (longestWord ?? "No words found"));
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error reading the file: " + ex.Message);
        //}

    }
}
