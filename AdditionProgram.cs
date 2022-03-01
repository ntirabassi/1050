// See https://aka.ms/new-console-template for more information
double x;
double y;
double z;


Console.Write("Type in a number from 1 to 10: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Type in a number from 10 to 100: ");
y = Convert.ToDouble(Console.ReadLine());

z = x + y;

Console.Write("The sum of these numbers is ");
Console.Write(z);

Console.ReadKey();


