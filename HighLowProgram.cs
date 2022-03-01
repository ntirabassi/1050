// See https://aka.ms/new-console-template for more information

Random rnd = new Random();

int Num1;
int Num2;
int Num3;

Num1 = rnd.Next(1, 10);
Num3 = 1;

Console.Write("Guess a number between 1 and 10: ");
Num2 = Convert.ToInt32(Console.ReadLine());

while (Num2 < Num1)
{
    Console.Write("Too low! Guess again: ");
    Num2 = Convert.ToInt32(Console.ReadLine());
    Num3 = Num3 + 1;
}

while (Num2 > Num1)
{
    Console.Write("Too high! Guess again: ");
    Num2 = Convert.ToInt32(Console.ReadLine());
    Num3 = Num3 + 1;
}

Console.Write("Correct! It took you ");
Console.Write(Num3);
Console.Write(" tries to get it right.");
Console.ReadKey();

