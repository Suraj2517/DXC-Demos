namespace InheritanceDemo
{
    public class Calculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return (a / b);
        }
    }
    public class ScientificCalculator : Calculator
    {
        public int Cube(int a)
        {
            return a * a * a;
        }
        public int Factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i < a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Sum(20, 20);

        }
    }
}