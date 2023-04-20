namespace Simple_Intrest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price");
            int P = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the rate");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time");
            int T = Convert.ToInt16(Console.ReadLine());

            double SI = (P*R*T)/100;

            Console.WriteLine("Your simple intrest is " + SI);
        }
    }
}