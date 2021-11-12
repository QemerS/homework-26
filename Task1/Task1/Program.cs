using System;

delegate int MyDelegate(int a, int b);
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate metod1 = new MyDelegate(Sum);
            MyDelegate metod2 = new MyDelegate(Substraction);
            MyDelegate metod3 = new MyDelegate(Division);
            MyDelegate metod4 = new MyDelegate(Multiplication);

            Console.WriteLine(metod1.Invoke(4, 2));
            Console.WriteLine(metod2.Invoke(4, 2));
            Console.WriteLine(metod3.Invoke(4, 2));
            Console.WriteLine(metod4.Invoke(4, 2));
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Substraction(int a, int b)
        {
            return a - b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
