﻿namespace task4
{
    internal class Program
    {
        static void Byvalue(int a)
        {
            a = 10; // This change won't affect the original variable
        }

        static void ByReference(ref int a)
        {
            a = 20; // This change will affect the original variable
        }

        static void sumAndsub(int a, int b,int c,int d, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        static int sumdigit(int num) 
        { 
            int sum = 0;
            while (num != 0) 
            {
                sum += num % 10;
                num /= 10;
                
            }
            return sum;
        }

        static bool isprime(int a) 
        {
            if ( a <=1 )  return false; 
            for (int i = 2; i <=Math.Sqrt(a); i++) 
                if (a % i == 0 ) return false;
            return true;

        }

        static void maxAndmin(int[] arr , ref int max , ref int min)
        {
            min = arr[0];
            max = arr[0];

            foreach (int i in arr) 
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }

        } 

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static string changechar(string str, int pos , char newChar)
        {
            if (pos < 0 || pos >= str.Length)
                return str ;
            char[] chars = str.ToCharArray();
            chars[pos] = newChar;
            return new string(chars);
        }

        static void Main()
        {
            #region Q1
            //int x = 5;
            //Byvalue(x);
            //Console.WriteLine($"After Byvalue: {x}"); // Output: 5 Not changed
            #endregion

            #region Q2
            //int y = 5;
            //ByReference(ref y);
            //Console.WriteLine($"After ByReference: {y}"); // Output: 20 Changed 
            #endregion

            #region Q3
            //Console.WriteLine("Enter 4 numbers : ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());

            //sumAndsub(a, b, c, d, out int sum, out int sub);
            //Console.WriteLine($"sum = {sum} ");
            //Console.WriteLine($"sub = {sub} ");
            #endregion

            #region Q4
            //Console.WriteLine("Enter a number to sum its digits: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of digits: {sumdigit(number)}");
            #endregion

            #region Q5
            //Console.WriteLine("Enter a number to check if it's prime: ");
            //int number = int.Parse(Console.ReadLine());
            //if (isprime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}

            #endregion

            #region Q6
            //int [] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = 0, min = 0;
            //maxAndmin(arr, ref max, ref min);   
            //Console.WriteLine($"Max = {max} , Min = {min}");

            #endregion

            #region Q7
            //Console.WriteLine("Enter a number to calculate its factorial: ");
            //int number = int.Parse(Console.ReadLine());
            //long result = Factorial(number);
            //Console.WriteLine($"Factorial of {number} is {result}");
            #endregion

            #region Q8

            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the position of the character to change (0-based index): ");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new character: ");
            char newchar = char.Parse(Console.ReadLine());

            string modifiedString = changechar(str, pos, newchar);
            Console.WriteLine($"Modified string: {modifiedString}");
            #endregion



        }
    }
}
