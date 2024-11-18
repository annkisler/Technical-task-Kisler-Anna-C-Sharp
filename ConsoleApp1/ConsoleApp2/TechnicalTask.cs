namespace ConsoleApp1.tests;

public class TechnicalTask
// first task
{
    public static void Main(string[] args)
    {
        // Step 1: Check if the entered number is bigger than 7 and print "Hello" if so.
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number > 7)
        {
            Console.WriteLine("Hello");
        }

        // Step 2: Check if the entered name matches "John" and output.
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        
        if (name == "John")
        {
            Console.WriteLine("Hello, John");
        }
        else
        {
            Console.WriteLine("There is no such name");
        }

        // Step 3: Input a numeric array and output elements that are multiples of 3.
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int[] array = new int[size];
        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        List<int> multiplesOfThree = new List<int>();

        foreach (int element in array)
        {
            if (element % 3 == 0)
            {
                multiplesOfThree.Add(element);
            }
        }

        Console.WriteLine("Array elements that are multiples of 3:");
        foreach (int multiple in multiplesOfThree)
        {
            Console.WriteLine(multiple);
        }
    }
}

// second task
//Given bracket sequence [((())()(())]] cannot considered as a correct one.
//Bracket sequence [((())()(()))] becomes correct, if we change ']' bracket before the last one to ')' bracket
