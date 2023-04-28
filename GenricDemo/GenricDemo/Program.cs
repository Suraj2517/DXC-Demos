namespace GenricDemo
{
    class Gene<S>
    {
        S num;
        public void Value(S x )
        {
            num = x;
        }
        public S GetValue()
        {
            return num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gene<int> gene = new Gene<int>();
            gene.Value(10);
            Console.WriteLine(gene.GetValue());

            Gene<string> gen1 = new Gene<string>();
            gen1.Value("Hello");
            Console.WriteLine(gen1.GetValue());

        }
    }
}