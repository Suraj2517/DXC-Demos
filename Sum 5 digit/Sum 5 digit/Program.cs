﻿int n, sum = 0, m;
Console.Write("Enter a 5 digit number: ");
n = int.Parse(Console.ReadLine());
while (n > 0)
{
    m = n % 10;
    sum = sum + m;
    n = n / 10;
}
Console.Write("Sum of all 5 digit is = " + sum);