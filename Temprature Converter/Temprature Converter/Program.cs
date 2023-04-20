namespace Temprature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temprature in celcius");
            int C = Convert.ToInt16(Console.ReadLine());

            double F = ((9/5) * C) + 32;

            Console.WriteLine("Temprature in farenheit is "+F);
        }
    }
}