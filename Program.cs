using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;

// Console.WriteLine("Hello, World!");

/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");          // --- FOR OUTPUT PROCESSING
        Console.WriteLine("This is a .NET 8.0 application using C# 12.0.");
        // Console.ReadLine();                          --- FOR INPUT PROCESSING
    }
}
*/

/*
class Program
{
    static void Main(string[] args)
    {
        int age = 22;                                       // Example variable declaration         --- Can also be put negative
        string name = "John Doe";                           // Example string variable 
        char initial = 'J';                                 // Example character variable

        Console.WriteLine($"Hello, {name}!");               // Output greeting with variable
        Console.WriteLine($"You are {age} years old.");     // Output age
        Console.WriteLine($"Your initial is {initial}.");   // Output initial

        long bigNumber = 9000000000L;                       // Example of a long integer variable   
        Console.WriteLine($"A Big Number: {bigNumber}");    // Output long integer 
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);

        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);

        double pi = 3.14D;                                  // Example of a double variable
        Console.WriteLine($"Value of Pi: {pi}");            // Output double variable
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);


        float precision = 5.000001F;                        // Example of a float variable
        Console.WriteLine($"Precision Value: {precision}"); // Output float variable
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(float.MinValue);  

        decimal money = 19.99M;                            // Example of a decimal variable
        Console.WriteLine($"Price: {money}");              // Output decimal variable with currency format
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(decimal.MinValue);    

        bool isActive = true;                              // Example of a boolean variable    
        Console.WriteLine($"Is Active: {isActive}");       // Output boolean variable

        int x = 10,
            y = 20,
            z = 30;


        // Converting String to Numbers

        string textNumber = "42";                           // Example string containing a number
        int aged = Convert.ToInt32(textNumber);             // Convert string to integer
        Console.WriteLine(aged);

        string textBigNumber = "1234567890123";             // Example string containing a large number
        long bigAged = Convert.ToInt64(textBigNumber);      // Convert string to long integer   
        Console.WriteLine(bigAged);

        string textNegativeNumber = "-55.2";                // Example string containing a negative number
        double negativeNumber = Convert.ToDouble(textNegativeNumber); // Convert string to double
        Console.WriteLine(negativeNumber);

        string textPrecision = "3.14159";                   // Example string containing a floating-point number
        float precisionNumber = Convert.ToSingle(textPrecision); // Convert string to float 


        // Boolean Data Type
        bool value = true;
        bool isMale = true;
        Console.WriteLine(isMale);

        isMale = false;
        Console.WriteLine(isMale);

    }
}
*/
/*
class Program
{
    static void Main(string[] args)
    {
        // int age = 23;
        var age = 23;                                                       // Example variable declaration using var  --- Simply Others are also possible
        age++;
        Console.WriteLine($"Your age is: {age}");                           // Output the incremented age 
        age--;
        Console.WriteLine($"Your age after decrement is: {age}");           // Output the decremented age 
        age = age + 1;
        Console.WriteLine($"Your age after another addition is: {age}");    // Output the age after addition
        age += 1;
        Console.WriteLine($"Your age after another addition is: {age}");    // Output the age after another addition

        // +, -, * , /
        age /= 10;  // -> 2.3 = 2
        Console.WriteLine(age);

        string name = "John";
        name += " Doe";                                                     // Concatenation    

        char ch = 'a';
        ch += 'b';                                                          // Character addition   

        Console.WriteLine(name);
        Console.WriteLine(ch);

        int i = 0;
        Console.WriteLine(++i);                                             // Postfix increment
        Console.WriteLine(i++);                                             // Prefix increment
        Console.WriteLine(i);                                               // Output the incremented value of i

    }
}
*/

/*
// const Keyword
namespace C__BASIC
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    const int vat = 20;
        //    Console.WriteLine(vat);
        //    vat = 10;                           // Once decalred, can't be changed.
        //    Console.ReadLine();
        //}


        static void Main(string[] args)
        {
            const int VAT = 20;
            const double percentVAT = 20 / 100D;

            int bal = 0;
            Console.WriteLine(bal * (20 / 100D));
            Console.WriteLine(VAT * percentVAT);

            const string version = "v2.0";
            Console.WriteLine(version);

        }
    }
}
*/

/*
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();                               // Read user input from console

            Console.WriteLine($"Hello, {name}!");                           // Output greeting with user input

            Console.WriteLine("Enter Your Age: ");
            string ageInput = Console.ReadLine();                           // Read user input for age
            if (int.TryParse(ageInput, out int age))                        // Try to parse the input as an integer
            {
                Console.WriteLine($"You are {age} years old.");              // Output age if parsing is successful
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a number."); // Output error message if parsing fails
            }

            Console.WriteLine($"Your name is {name} and you're {age} years old.");
        }
    }
}
*/

/*
// Example of if statement
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            string ageInput = Console.ReadLine();                           // Read user input for age
            if (int.TryParse(ageInput, out int age))                        // Try to parse the input as an integer
            {
                if (age < 18)                                                // Check if age is less than 18
                {
                    Console.WriteLine("You are a minor.");                  // Output message for minors
                }
                else if (age >= 18 && age < 65)                              // Check if age is between 18 and 65
                {
                    Console.WriteLine("You are an adult.");                 // Output message for adults
                }
                else                                                        // For ages 65 and above
                {
                    Console.WriteLine("You are a senior citizen.");         // Output message for seniors
                }
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a number."); // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of switch statement
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Day of the Week (1-7): ");
            string input = Console.ReadLine();                               // Read user input for day of the week
            if (int.TryParse(input, out int day))                            // Try to parse the input as an integer
            {
                switch (day)                                                 // Switch statement based on the day value
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid day. Please enter a number between 1 and 7."); // Output error message for invalid input
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number."); // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of for loop
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();                               // Read user input for the number
            if (int.TryParse(input, out int number))                         // Try to parse the input as an integer
            {
                for (int i = 1; i <= number; i++)                            // Loop from 1 to the entered number
                {
                    Console.WriteLine(i);                                    // Output each number in the loop
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number."); // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of while loop
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();                               // Read user input for the number
            if (int.TryParse(input, out int number))                         // Try to parse the input as an integer
            {
                int i = 1;                                                   // Initialize counter variable
                while (i <= number)                                          // Loop while i is less than or equal to the entered number
                {
                    Console.WriteLine(i);                                    // Output each number in the loop
                    i++;                                                     // Increment counter variable
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");  // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of do-while loop
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();                               // Read user input for the number
            if (int.TryParse(input, out int number))                         // Try to parse the input as an integer
            {
                int i = 1;                                                   // Initialize counter variable
                do                                                           // Start of do-while loop
                {
                    Console.WriteLine(i);                                    // Output each number in the loop
                    i++;                                                     // Increment counter variable
                } while (i <= number);                                       // Continue looping while i is less than or equal to the entered number
            }
            // Note: The do-while loop guarantees that the loop body will execute at least once, even if the condition is false initially.
            // This is different from the while loop, which checks the condition before executing the loop body.
            // This is useful when you want to ensure that the loop body runs at least once, regardless of the initial condition.
            // 
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");  // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of foreach loop
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie" };                 // Example array of names
            foreach (string name in names)                                  // Foreach loop to iterate through each name in the array
            {
                Console.WriteLine(name);                                    // Output each name in the loop
            }
            // Note: The foreach loop is used to iterate over collections or arrays without needing to manage the index manually.
        }
    }
}
*/
/*
// Conditional or Ternary Operator Example
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Age: ");
            string input = Console.ReadLine();                               // Read user input for age
            if (int.TryParse(input, out int age))                            // Try to parse the input as an integer
            {
                string category = (age < 18) ? "Minor" : "Adult";           // Conditional operator to determine category based on age
                Console.WriteLine($"You are categorized as: {category}");   // Output the category
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number."); // Output error message if parsing fails
            }
        }
    }
}
*/
/*
// Example of null-coalescing operator
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;                                             // Example of a null string
            string result = input ?? "Default Value";                        // Null-coalescing operator to provide a default value if input is null
            Console.WriteLine(result);                                       // Output the result
            // Note: The null-coalescing operator (??) is used to provide a fallback value when the left-hand operand is null.
            // This is useful for providing default values in case of null references.
        }
    }
}
*/
/*
// Example of Numeric Formatting
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 1234567.89;                                      // Example number for formatting
            Console.WriteLine($"Default Format: {number:0.00}");             // Default formatting
            // Only two decimal places are shown

            Console.WriteLine($"Currency Format: {number:C}");               // Currency formatting
            Console.WriteLine($"Fixed-point Format: {number:F2}");           // Fixed-point formatting with 2 decimal places
            Console.WriteLine($"Scientific Format: {number:E}");             // Scientific notation formatting

            double money = -10D / 3D;
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.GetCultureInfo("en-US")));                                // Currency formatting in US culture
        }
    }
}
*/
/*
// Example of TryParse Method
namespace C__BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();                               // Read user input for the number
            if (int.TryParse(input, out int number))                         // Try to parse the input as an integer
            {
                Console.WriteLine($"You entered: {number}");                 // Output the parsed number
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); // Output error message if parsing fails
            }
        }
    }
}
*/
/*
 * TABLE 
class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, num, i * num);
        }
    }
}
*/
/*
// Fizz Buzz Game
class Program
{
    static void Main(String[] args)
    {
        bool threeDiv = false;
        bool fiveDiv = false;

        for (int i = 1; i <= 15; i++)
        {
            threeDiv = i % 3 == 0;
            fiveDiv = i % 5 == 0;

            if (threeDiv && fiveDiv)
            {
                Console.WriteLine("FizzBuzz");
            } else if (threeDiv)
            {
                Console.WriteLine("Fizz");
            } else if (fiveDiv)
            {
                Console.WriteLine("Buzz");
            } else
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/

// Verbatim String Literal '@'
// Escape Characters Example
// treated as ->  /

/*
class Program
{
    static void Main(string[] args)
    {
        // \t \n \" \\ = \
        string speech = "He said \"something\".";
        string path = "C:\\Users\\SyedFaisal\\Desktop\\TRAINING MODULES\\C# BASICS\\Program.cs";
        Console.WriteLine(speech);
        Console.WriteLine(path);

        //$ +
        // $"Your Name is {name}"
        // "Your name is " + name

        path = @"C:\Users\SyedFaisal\Desktop\TRAINING MODULES\C# BASICS\Program.cs"; 
        Console.WriteLine(path);

        string name = @"Hello ""someone""";
        Console.WriteLine(name); 

        name = @"Hello 'someone'";
        Console.WriteLine(name);    
    }
}
*/

// String Formatting Example

// String Interpolation Example

// String Concatenation Example

// Empty String
/*
class Program
{
    static void Main(String[] args)
    {
        string message = "Hello";
        string compare = "Hello";

        if (message.Equals(compare))
        {
            Console.WriteLine("Same");
        } else
        {
            Console.WriteLine("Different");
        }

        Console.Write("Enter your Name : ");
        string name = Console.ReadLine();

        // if (name != "")
        if (!name.Equals(""))
        {
            Console.WriteLine("Your name is " +name);
        } else
        {
            Console.WriteLine("Invalid Line Input.");
        }


        char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o'};   
        object newComp = new string(chars);

        if (message.Equals(newComp))
        {
            Console.WriteLine("Same");
        } else
        {
            Console.WriteLine("Different");
        }
    }
}
*/
/*
// String Iteration (Looping)
class Program
{
    static void Main(String[] args)
    {
        string message = "C# is awesome.";
        // Console.WriteLine(message);

        // Console.WriteLine(message[0]);
        // Console.WriteLine(message[1]);
        // Console.WriteLine(message[2]);  
        // Console.WriteLine(message[3]);

        // Using for loop
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i]);
            Thread.Sleep(1000);                                             // Adding a delay of 100 milliseconds between each character output
            Console.WriteLine(message.Contains("C"));
            
            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                    break;                                                  // Exit the loop if 'C' is found
                } else {
                    contains = false;
                }
            }
        }
    }
}
*/

// String IsNullOrEmpty Function

/*
// Print the string in reverse order
class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter a message: ");
        string message = Console.ReadLine();

        // Prints In-Order
        Console.WriteLine($"\nOriginal Message: {message}");
        
        Console.Write("Reversed Message: ");
        for (int i = message.Length - 1; i >= 0; i--)                    // Loop through the string in reverse order
        {
            Console.Write(message[i]);                                // Append each character to the reversed message
        }
        Console.WriteLine();                            // Output the reversed message
    }
}
*/

/*
// Password Checking Example
class Program
{
    static void Main(String[] args)
    {
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter Password Again: ");
        string passwordC = Console.ReadLine();  

    
        if (!password.Equals(string.Empty))
        {
            if (!passwordC.Equals(String.Empty))
            {
                if (password.Length >= 6 && passwordC.Length >= 6)
                {
                    if (password.Equals(passwordC))
                    {
                        Console.WriteLine("Password is valid and matches.");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match.");
                    }
                }
                else
                {
                    Console.WriteLine("Password must be at least 6 characters long.");
                }
            }
            else
            {
                Console.WriteLine("Please enter the password again.");
            }
        }
    }
}
*/

/*
// Array Example
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array Elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Accessing elements by index
        Console.WriteLine($"First Element: {numbers[0]}");
        Console.WriteLine($"Second Element: {numbers[1]}");
        
        // Modify an element in the array
        numbers[2] = 10;
        Console.WriteLine($"Modified Third Element: {numbers[2]}");
    }
}
*/

/*
// Sorting an Array Example
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5] { 5, 3, 8, 1, 4 };
        
        Console.WriteLine("Original Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        // Sorting the array
        Array.Sort(numbers);
        Console.WriteLine("\nSorted Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/

/*
// Multidimensional Array Example
class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3] 
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Matrix Elements:");
        for (int i = 0; i < matrix.GetLength(0); i++)                   // GetLength(0) gives the number of rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++)               // GetLength(1) gives the number of columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();                                        // New line after each row
        }
    }
}
*/

/*
// Reverse an Array Example
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        // Reversing the array
        Array.Reverse(numbers);
        Console.WriteLine("\nReversed Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
// We can do the same by iterating through the array in reverse order
*/

/*
// Clear an Array Example -- Only used to clear the array elements, not to remove the array itself
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Original Array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        // Clearing the array
        Array.Clear(numbers, 0, numbers.Length);
        Console.WriteLine("\nArray after Clear:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number); // All elements will be zero after clearing
        }
    }
}
*/

/*
// Jagged Array Example
class Program
{
    static void Main(string[] args)
    {
        // Jagged array declaration and initialization
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        
        Console.WriteLine("Jagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            foreach (int number in jaggedArray[i])
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();                                        // New line after each row
        }
    }
}
*/

/*
// IndexOf and LastIndexOf Example
class Program
{
    static void Main(string[] args)
    {
        string[] fruits = new string[] { "Apple", "Banana", "Cherry", "Apple", "Date" };
        
        // Finding the index of the first occurrence of "Apple"
        int firstIndex = Array.IndexOf(fruits, "Apple");
        Console.WriteLine($"First Index of 'Apple': {firstIndex}");
        
        // Finding the index of the last occurrence of "Apple"
        int lastIndex = Array.LastIndexOf(fruits, "Apple");
        Console.WriteLine($"Last Index of 'Apple': {lastIndex}");
    }
}
*/
// -> Arrays are fixed in size once declared, meaning you cannot change the size of an array after it has been created.
// If you need a dynamic collection that can grow or shrink in size, consider using collections like `List<T>` or `ArrayList`.
// But we can also increase the size of an array by creating a new array with a larger size and copying the elements from the old array to the new one. But, it's a fuck up task.
// int [] numbers = new int[4];
// int [] newNumbers = new int[5];
// 0-3 [4] -> 0-3 [5]

/*
// Lists
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Array of fixed size, unused here but defined
        int[] numbers = new int[3] { 1, 2, 3 };

        // Create a list to hold integers
        List<int> listNumbers = new List<int>();

        // Input 3 numbers from the user
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter a Number: ");
            int input;
            bool isValid = int.TryParse(Console.ReadLine(), out input);
            if (isValid)
                listNumbers.Add(input);
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // retry current iteration
            }
        }

        // Display the numbers entered
        Console.WriteLine("\nYou entered:");
        for (int i = 0; i < listNumbers.Count; i++)
        {
            Console.WriteLine(listNumbers[i]);
        }
    }
}
*/

/*
// Dictionary Example
namespace BASIC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Create a dictionary to hold key-value pairs
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
            
            // Add some entries to the dictionary
            ageDictionary.Add("Alice", 30);
            ageDictionary.Add("Bob", 25);
            ageDictionary.Add("Charlie", 35);
            
            // Display the entries in the dictionary
            Console.WriteLine("Age Dictionary:");
            foreach (var entry in ageDictionary)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} years old");
            }
            


            // Create dictionary with case-insensitive keys
            Dictionary<string, string> teachers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Alice", "Maths" },
                { "Bob", "Science" },
                { "Charlie", "English" }
            };

            // Check if a specific teacher teaches Maths (case-insensitive)
            if (teachers.ContainsValue("Maths"))
            {
                // Replace teacher who teaches Maths with Joe
                foreach (var key in teachers.Keys)
                {
                    if (teachers[key].Equals("Maths", StringComparison.OrdinalIgnoreCase))
                    {
                        teachers[key] = "Joe";
                        Console.WriteLine($"Reassigned Maths to Joe (was previously assigned to {key})");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No teacher found for Maths.");
            }

            // Remove entry for "Science" if it exists
            if (teachers.ContainsValue("Science"))
            {
                string teacherToRemove = null;

                foreach (var pair in teachers)
                {
                    if (pair.Value.Equals("Science", StringComparison.OrdinalIgnoreCase))
                    {
                        teacherToRemove = pair.Key;
                        break;
                    }
                }

                if (teacherToRemove != null)
                {
                    teachers.Remove(teacherToRemove);
                    Console.WriteLine($"Removed teacher {teacherToRemove} who was teaching Science.");
                }
            }
            else
            {
                Console.WriteLine("No teacher found for Science.");
            }

            // Optional: Print remaining dictionary
            Console.WriteLine("\nUpdated teacher list:");
            foreach (var kvp in teachers)
            {
                Console.WriteLine($"{kvp.Key} teaches {kvp.Value}");
            }
        }    
    }
}
*/

/*
// HW - 1
// Create 2 lists with integer values, one for even numbers and one for odd numbers. Loop from 0-2 and if number is even, add it to the even list, otherwise add it to the odd list. Print both lists at the end.
class Program
{
    static void Main(string[] args)
    {
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }
            else
            {
                oddNumbers.Add(i);
            }
        }
        Console.WriteLine("Even Numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nOdd Numbers:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/

/*
// HW - 2 
// Define and initialize two integers (num, length). Create int array with size length and loop through and insert the (loop counter x num) into the array. Print the array at the end.
class Program
{
    static void Main(string[] args)
    {
        int num = 5;                        // Example multiplier
        int length = 10;                    // Size of the array
        int[] resultArray = new int[length];
        int counter = 0;                    // Counter for the array index
        for (int i = 0; i < resultArray.length; i++, counter++)
        {
            resultArray[counter] = i * num;       // Insert (loop counter x num) into the array
        }
        Console.WriteLine("Resulting Array:");
        foreach (var item in resultArray)
        {
            Console.WriteLine(item); // Print each element of the array
        }
    }
}
*/

/*
// Functions
namespace BASIC
{
    class Program
    {
        static void Main(String[] args)
        {
            bool suc = int.TryParse("123", out int result);
            Console.WriteLine($"Parsed Result: {suc}"); // Output the parsed result
        }
    }
}
*/

/*
// Example of a function that takes parameters and returns a value  
class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        int sum = Add(num1, num2);                                      // Call the Add function with two integers
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");   // Output the result
    }
    // Function to add two integers and return the result
    static int Add(int a, int b)
    {
        return a + b;                                                   // Return the sum of a and b
    }
}
*/

/*
// Example of a Overloading Constructor
class Program
{
    // Class to represent a person with name and age
    class Person
    {
        public string Name { get; set; }                               // Property for person's name
        public int Age { get; set; }                                   // Property for person's age
        // Constructor with both name and age parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Constructor with only name parameter, default age is set to 0
        public Person(string name)
        {
            Name = name;
            Age = 0;                                                  // Default age if not provided
        }
        // Method to display person's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    static void Main(string[] args)
    {
        Person person1 = new Person("Alice", 30);                     // Create a Person object with name and age
        Person person2 = new Person("Bob");                           // Create a Person object with only name
        person1.DisplayInfo();                                        // Display information for person1
        person2.DisplayInfo();                                        // Display information for person2
    }
}
*/

/*
// Example of an Overriding Method
class Program
{
    // Base class representing a vehicle
    class Vehicle
    {
        public virtual void Start()                                     // Virtual method to start the vehicle
        {
            Console.WriteLine("Vehicle is starting.");
        }
    }
    // Derived class representing a car, which overrides the Start method
    class Car : Vehicle
    {
        public override void Start()                                   // Override the base class method
        {
            Console.WriteLine("Car is starting with a roar!");
        }
    }
    static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle();                              // Create an instance of Vehicle
        myVehicle.Start();                                              // Call the Start method of Vehicle
        Car myCar = new Car();                                          // Create an instance of Car
        myCar.Start();                                                  // Call the overridden Start method of Car
    }
}

// It overrides the base class method to provide a specific implementation for the derived class.
*/

/*
// Example of a Reference Parameter
class Program
{
    static void Main(string[] args)
    {
        int number = 10;                                                // Initialize an integer variable
        Console.WriteLine($"Before: {number}");                        // Output the value before calling the function
        ModifyValue(ref number);                                        // Call the function with a reference parameter
        Console.WriteLine($"After: {number}");                         // Output the value after calling the function
    }
    // Function that modifies the value of the passed integer using a reference parameter
    static void ModifyValue(ref int num)
    {
        num += 5;                                                      // Increment the value by 5
        Console.WriteLine($"Inside Function: {num}");                 // Output the modified value inside the function
    }
}
*/

/*
class Program
{
    static void Main(string[] args)
    {
        // 1. Declare variables
        int num = 10;
        string name = "Faisal";

        // 2. Modify using a method with ref parameters
        Assign(ref num, ref name);
        Console.WriteLine($"Number: {num}, Name: {name}"); // Outputs: Number: 20, Name: Faisal

        // 3. Try parsing an empty string to integer
        int index = 0;
        int.TryParse("", out index); // index will be 0 since input is invalid
        Console.WriteLine($"Parsed Index: {index}");

        // 4. Attempt to change name via user input
        Console.Write("Enter your New Name: ");
        string newName = Console.ReadLine();

        if (ChangeName(ref name, newName))
        {
            Console.WriteLine($"Your new name is {name}!");
        }
        else
        {
            Console.WriteLine("Name change failed. Please try again.");
        }
    }

    // Method to assign new values to num and name
    static void Assign(ref int num, ref string name)
    {
        num = 20;
        name = "Faisal";
    }

    // Method to change the name if the new name is not null or empty
    static bool ChangeName(ref string name, string newName)
    {
        if (!string.IsNullOrEmpty(newName)) // FIXED: Needed to pass newName to IsNullOrEmpty
        {
            name = newName;
            return true;
        }
        else
        {
            return false;
        }
    }
}
*/


// HW - 1
// Ask user for width and height, store them create functions to calculate the area. Function should calculate the area and return it. Call main function and print the area of the triangle.

/*
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        
        // Call the function to calculate the area of the triangle
        double area = CalculateArea(width, height);
        Console.WriteLine($"Area of the Triangle: {area}");
    }
    static double CalculateArea(double width, double height)
    {
        return 0.5 * width * height; // Area of triangle formula: 1/2 * base * height
    }
}
*/

// HW - 2
// Creates and initializes an int[] array.
// Defines a method SumOfNumbers(int[] numbers) that:
// Returns the sum of numbers in the array.
// Returns -1 if the array is null or empty.
// Calls the function in Main(), handles the return value, and prints the result or appropriate message.

/*
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };                    // Example array
        int sum = SumOfNumbers(numbers);
        
        if (sum != -1)
        {
            Console.WriteLine($"Sum of Numbers: {sum}");
        }
        else
        {
            Console.WriteLine("Array is null or empty.");
        }
    }
    static int SumOfNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)                     // Check if the array is null or empty
        {
            return -1;                                                  // Return -1 if the array is null or empty
        }
        int sum = 0; 
        foreach (int number in numbers)                                 // Loop through each number in the array
        {
            sum += number;                                              // Add each number to the sum
        }
        
        return sum; 
    }
}
*/