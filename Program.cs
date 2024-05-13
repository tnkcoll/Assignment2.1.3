using System.ComponentModel;

namespace Assignment2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMathOperations.Add(5, 5));
            Console.WriteLine(SimpleMathOperations.Add(5.2M, 5.4M, 5.6M));
            Console.WriteLine(SimpleMathOperations.Multiply(5.2f, 5.4f));
            Console.WriteLine(SimpleMathOperations.Multiply(5.2f, 5.4f, 5.6f));
        }
    }

    public class SimpleMathOperations()
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
