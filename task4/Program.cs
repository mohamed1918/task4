namespace task4
{
    internal class Program
    {
        static void Byvalue(int a)
        {
            a = 10; // This change won't affect the original variable
        }

        
        static void Main()
        {
            #region Q1
            int x = 5;
            Byvalue(x);
            Console.WriteLine($"After Byvalue: {x}"); // Output: 5 Not changed
            #endregion

          
        }
    }
}
