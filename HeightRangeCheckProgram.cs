// See https://aka.ms/new-console-template for more information

double height;

Console.WriteLine("How tall are you in inches?");
Console.Write("Type a number and press enter: ");
height = Convert.ToDouble(Console.ReadLine());

if (height < 60 || height > 75)
{
   Console.WriteLine("You do not have an average height!");
}
else
{
    Console.WriteLine("You have a normal height.");
}

Console.ReadKey();  