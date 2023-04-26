namespace OOP_Demo
{
    class Calculator
    {
        public void Show()
        {
            Console.WriteLine("This is hello from myside");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public void Add(int a, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Show();
            calc.SayHello("Raja");
            calc.SayHello("M S");
            calc.Sum(10, 2, 3);
            int res = calc.Cube(7);
            Console.WriteLine(res);
            calc.Add(10, 20);
        }
    }
}
