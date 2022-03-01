// See https://aka.ms/new-console-template for more information

double score;
double a;

a = 5;

Console.WriteLine("Question 1. What is 34 - 4?");
Console.Write("Type an answer and press enter: ");
score= Convert.ToDouble(Console.ReadLine());

if (score != 30)
{
    Console.WriteLine("Sorry, that is wrong.");
    a = a - 1;
}
else
{
   Console.WriteLine("Correct!");

}

Console.WriteLine("Question 2. What is 5 x 10?");
Console.Write("Type an answer and press enter: ");
score = Convert.ToDouble(Console.ReadLine());

if (score != 50)
{
    Console.WriteLine("Sorry, that is wrong.");
    a = a - 1;
    
}
else
{
    Console.WriteLine("Correct!");
   
}

Console.WriteLine("Question 3. What is 49 - 2?");
Console.Write("Type an answer and press enter: ");
score = Convert.ToDouble(Console.ReadLine());

if (score != 47)
{
    Console.WriteLine("Sorry, that is wrong.");
    a = a - 1;
}
else
{
    Console.WriteLine("Correct!"); 
}

Console.WriteLine("Question 4. What is 8 x 9?");
Console.Write("Type an answer and press enter: ");
score = Convert.ToDouble(Console.ReadLine());

if (score != 72)
{
    Console.WriteLine("Sorry, that is wrong.");
    a = a - 1;
}
else
{
    Console.WriteLine("Correct!");
   
}

Console.WriteLine("Question 5. What is 20 + 14?");
Console.Write("Type an answer and press enter: ");
score = Convert.ToDouble(Console.ReadLine());

if (score != 34)
{
    Console.WriteLine("Sorry, that is wrong.");
    a = a - 1;
}
else
{
    Console.WriteLine("Correct!");
   
}



Console.Write("Thank you for taking this test. Your score is ");
Console.Write(a);
Console.WriteLine(" out of 5.");

Console.ReadKey();