Console.WriteLine("Enter five numbers");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());
            int d = Convert.ToInt16(Console.ReadLine());
            int e = Convert.ToInt16(Console.ReadLine());

            int Sum = a+b+c+d+e;
            Console.WriteLine("Sum of all five numbers is "+Sum);

            int Avg = Sum/5;
            Console.WriteLine("Average of all five numbers is "+Avg);