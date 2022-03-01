// See https://aka.ms/new-console-template for more information

double a;
double b;
double c;
double x;

Console.Write("Type in your first test score: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Type in your second test score: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Type in your third test score: ");
c = Convert.ToDouble(Console.ReadLine());

x = a + b + c;
x = x / 3;

Console.Write("The average of your scores is ");
Console.WriteLine(x);

if (x < 60)
{
    Console.WriteLine("You have an F in the class.");
}
else if (x >= 60 && x < 69)
{
    Console.WriteLine("You have a D in the class.");
}
else if (x >= 70 && x < 79)
{
    Console.WriteLine("You have a C in the class.");
}
else if (x >= 80 && x < 89)
{
    Console.WriteLine("You have a B in the class.");
}
else
{
    Console.WriteLine("You have a A in the class.");
}

Console.ReadKey();



