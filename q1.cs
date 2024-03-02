using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare three variables to store the input numbers
        int num1, num2, num3;

        // Prompt the user to input three numbers
        Console.WriteLine("Please enter three numbers:");

        // Read the input numbers and convert them to integers
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        num3 = int.Parse(Console.ReadLine());

        // Declare three variables to store the sorted numbers
        int min, mid, max;

        // Compare the input numbers and assign them to the sorted variables
        if (num1 <= num2 && num1 <= num3)
        {
            min = num1;
            if (num2 <= num3)
            {
                mid = num2;
                max = num3;
            }
            else
            {
                mid = num3;
                max = num2;
            }
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            min = num2;
            if (num1 <= num3)
            {
                mid = num1;
                max = num3;
            }
            else
            {
                mid = num3;
                max = num1;
            }
        }
        else
        {
            min = num3;
            if (num1 <= num2)
            {
                mid = num1;
                max = num2;
            }
            else
            {
                mid = num2;
                max = num1;
            }
        }

        // Output the sorted numbers in ascending order
        Console.WriteLine("The numbers in ascending order are:");
        Console.WriteLine(min);
        Console.WriteLine(mid);
        Console.WriteLine(max);
    }
}

