namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth of the rectangle");
            int l = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());

            int P = 2*(l + b);

            Console.WriteLine(P);

        }
    }
}