// See https://aka.ms/new-console-template for more information
double x;
double c;

Console.Write("Type the radius of a circle and press enter: ");
x = Convert.ToDouble(Console.ReadLine());

c = x * x * 3.14;

Console.Write("The area is ");
Console.Write(c);
Console.WriteLine(".");

c = 2 * 3.14 * x;

Console.Write("The circumference is ");
Console.Write(c);
Console.WriteLine(".");

Console.ReadKey(); 


