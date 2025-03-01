using System;

class Program
{
    static void Main()
    {
        //Console.Write("Enter your Name: ");
        //string name = Console.ReadLine(); // Read name input

        //Console.Write("Enter your age: ");
        //int age;

        //// Ensure valid integer input
        //while (!int.TryParse(Console.ReadLine(), out age))
        //{
        //    Console.Write("Invalid input. Please enter a valid age: ");
        //}

        //// Increment age
        //int nextAge = age + 1;

        //// Print final message
        //Console.WriteLine("Good morning " + name + "! Happy Birthday, your age becomes: " + nextAge);



        //for (int i = 0; i < 10; i++) {
        //    Console.WriteLine("i is: "+ i);
        //}

        //Car car = new Car(2019, "Stander"); // Correct object instantiation
        //Console.WriteLine(car.Drive());


        //int[] numbers = new int[10]; // Create an array with 10 elements
        //Random random = new Random(); // Create an instance of Random


        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = random.Next(1, 101);
        //}

        //// Print the random numbers
        //Console.WriteLine("Random Numbers:");
        //foreach (int num in numbers)
        //{
        //    Console.WriteLine(num + " ");
        //}


        int[] numbers = { 10, 20, 30, 40, 50 };
        foreach (int num in numbers) {
            Console.Write(num+ " ");
        }

        Console.WriteLine("");

        int[] arrNums = { 15, 42, 7, 89, 23 };
        int maxNumber = arrNums.Max(); // Use LINQ to find the max value
        Console.WriteLine("Maximum Number: " + maxNumber);

        //Q3
        int[] nums = { 1, 2, 3, 4, 5 };

        Array.Reverse(nums); // Reverse the array

        Console.WriteLine("Reversed Array: " + string.Join(", ", nums));

        //Q4 

        int[] oddEven = { 3, 6, 9, 12, 15, 18 };
        int oddCount = 0;
        int evenCount = 0;
        Console.Write("Even numbers: ");
        foreach (int num in oddEven)
        {
            if (num % 2 == 0)
                evenCount++;
        }
        Console.Write(evenCount);
        Console.WriteLine();

        Console.Write("Odd numbers: ");
        foreach (int num in oddEven)
        {
            if (num % 2 != 0)
                oddCount++;
        }
        Console.Write(oddCount);


        Console.WriteLine();

        int[] sumNumbers = { 5, 10, 15, 20 };
        int sumNum = 0;
        foreach (int sum in sumNumbers)
        {
            sumNum += sum;
        }

        Console.WriteLine("Sum of array elements: " + sumNum);
    }
}
