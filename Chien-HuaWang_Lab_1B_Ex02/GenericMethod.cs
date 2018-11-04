// Fig. 20.3: GenericMethod.cs
// Using a generic method to display arrays of different types.
using System;

class GenericMethod
{
    public static void Main(string[] args)
    {
        // create arrays of int, double and char
        int[] intArray = { 1, 2, 3, 4, 5, 6 };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
        char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
        try
        {
            Console.Write("Array intArray contains: ");
            DisplayArray(intArray, 2, 5); // pass an int array argument
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray, 2, 4); // pass a double array argument
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray, 2, 3); // pass a char array argument
        }
        catch (Exception e)
        {
            Console.WriteLine("\n" + "ERROR! " + e.Message);
        }

    }

    // output array of all types                           
    private static void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
    {
        if (lowIndex < 0 || highIndex < 0)
            throw new Exception("The Index is negative");
        if (highIndex > inputArray.Length || lowIndex > inputArray.Length)
            throw new ArgumentException("The Index is out of range");
        if (lowIndex > highIndex || highIndex == lowIndex)
            throw new ArgumentException("The highIndex is less than or equal to lowIndex,");
        else
        {

            for (int i = lowIndex; i < highIndex; i++)
            {
                Console.Write($"{inputArray[i]}, ");
            }

            Console.WriteLine();
        }
    }
}

