namespace task4
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
            Console.WriteLine("Enter a number to sum its digits: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of digits: {sumdigit(number)}");
            #endregion
        }
    }
}
