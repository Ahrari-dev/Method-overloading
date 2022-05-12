using System;

namespace MethodsExcercise
{
    class Program
    {
        private static void Main(string[] args)
        {
            //{
            //    Add(1, 1);
            //    Add(2.2, 3.3);
            //}
            //public static void Add(int x, int y)
            //{
            //    int answer = x + y;
            //    Console.WriteLine(answer);
            //}
            //public static void Add(double x, double y)
            //{
            //    double answer = x + y;
            //    Console.WriteLine(answer);
            //}

            Add(1, 4, true);

            Console.ReadKey(true);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool showResult)
        {
            var result = Add(a, b);

            if (showResult)
            {
                Console.WriteLine(result);
            }

            return result.ToString();
        }
    }
}