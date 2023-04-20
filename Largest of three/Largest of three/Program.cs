using System;

int num1, num2, num3;
Console.WriteLine("Enter First Number");
num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number");
num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Third Number");
num3 = Convert.ToInt16(Console.ReadLine());
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine("First Number is Largest");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine("Second Number is Largest");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine("Third Number is Largest");
}
else
{
    Console.WriteLine("All are equal");
}