using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6.WorkingWithMethods
{
    internal class ReverseTheArray
    {
    }

    //class Program
    //{
    //    public static int[] GenerateNumbers(int numberOfArray)
    //    {
    //        int[] ints = new int[numberOfArray];
    //        for (int i = 0; i < numberOfArray; i++)
    //            ints[i] = i;
    //        return ints;
    //    }

    //    public static int[] Reverse(int[] numbers)
    //    {
    //        // solution 1
    //        //int[] reverseArray = new int[numbers.Length];
    //        //for (int i = 0; i < numbers.Length; i++)
    //        //{
    //        //    reverseArray[i] = numbers[numbers.Length - 1 - i];
    //        //}

    //        //for (int i = 0; i < numbers.Length; i++)
    //        //{
    //        //    numbers[i] = reverseArray[i];
    //        //}

    //        //return numbers;

    //        // solution 2:
    //        int left = 0;
    //        int right = numbers.Length - 1;
    //        while (left < right)
    //        {
    //            int a = numbers[left];
    //            numbers[left] = numbers[right];
    //            numbers[right] = a;
    //            left++;
    //            right--;
    //        }
    //        return numbers;
    //    }

    //    public static void PrintNumbers(int[] numbers)
    //    {
    //        for (int i = 0; i < numbers.Length; i++)
    //        {
    //            Console.Write($"{numbers[i]} ");
    //        }
    //    }


    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter number of element in an array: ");
    //        int a = int.Parse(Console.ReadLine());
    //        int[] numbers = GenerateNumbers(a);
    //        Reverse(numbers);
    //        PrintNumbers(numbers);

    //    }
    //}
}
