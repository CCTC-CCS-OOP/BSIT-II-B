using System;

namespace MyOOPProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" I am" + " your personal assistant, Claude.");
            int a = 5;
            double b = 5.5;
            string c = "Claude";

            if (a > 3)
            {
                Console.WriteLine("For me, pineapple on pizzas are the best!");
            }
            else
            {
                Console.WriteLine("For me, pineapple on pizzas suck!");
            }

            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int sum = Sum(5, 6);
            Console.WriteLine("The sum is " + sum);

            try
            {
                int division = Division(10, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Get better at Math.");
            }
            finally
            {
                Console.WriteLine("Let me know if you need anything else.");
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}