String ch;
    do
    {
        Console.WriteLine("Enter the Temperature in Degree Celsius: ");
        int C = Convert.ToInt16(Console.ReadLine());

        double F = C * 1.8 + 32;
        Console.WriteLine("Temperature(Celsius): " + C + "     Temperature(Fahrenheit): " + F);
        Console.WriteLine("Do You Wish to Continue(y/n)?");
        ch = Console.ReadLine();
    } while (ch == "y");
