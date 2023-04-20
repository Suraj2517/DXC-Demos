using System;
using System.Xml.Schema;

int ID;
Console.WriteLine("Enter Student ID");
ID = Convert.ToInt16(Console.ReadLine());
String ch1;
Console.WriteLine("Enter Student name");
ch1 = Convert.ToString(Console.ReadLine());
int age, M1, M2, M3;
Console.WriteLine("Enter Student age");
age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 1");
M1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 2");
M2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 3");
M3 = Convert.ToInt16(Console.ReadLine());

int t = M1 + M2 + M3;
Console.WriteLine("Your total score is " + t);
int per = t / 3;
Console.WriteLine("Your average score is " + per);

if (per > 50)
{
    if (per >= 90 && per <= 100) 
    Console.WriteLine("Your grade is A");
    else if (per >= 80 && per <= 89)
    Console.WriteLine("Your grade is B");
    else if (per >= 60 && per <= 79) 
    Console.WriteLine("Your grade is C");
    else if (per >=50 && per <= 59) 
    Console.WriteLine("Your grade is D");
    Console.WriteLine("Your result for the exam is Pass");
}
else
{
    Console.WriteLine("Your grade is E");
    Console.WriteLine("Your result for the exam is Fail");
}



