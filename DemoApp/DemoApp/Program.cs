namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("Enter first number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
    }
}