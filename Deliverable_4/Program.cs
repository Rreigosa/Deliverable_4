namespace Deliverable_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[25];
            
            fib[0] = 0;
            fib[1] = 1;
            
            for (int i = 2; i < 25; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            for (int i = 0; i < 25; i++)
                Console.WriteLine("Fibonacci(" + i + ") = " + fib[i]);
        }
    }
}