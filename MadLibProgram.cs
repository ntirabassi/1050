// See https://aka.ms/new-console-template for more information
Console.WriteLine("Saturday Morning News");

string noun;
string verb;
string place;
string adjective;
string animal;

Console.Write("Type a noun and press enter: ");
noun = Console.ReadLine();

Console.Write("Type a verb and press enter: ");
verb = Console.ReadLine();

Console.Write("Type a place and press enter: ");
place = Console.ReadLine();

Console.Write("Type an adjective and press enter: ");
adjective = Console.ReadLine();

Console.Write("Type an animal and press enter: ");
animal = Console.ReadLine();

Console.Write("Last night, a strange burglary occured at Happy's ");
Console.Write(noun);
Console.Write(" Shop. ");
Console.Write("The only thing stolen was a doll that can ");
Console.Write(verb);
Console.Write(" and churn butter. ");
Console.Write("The residents of ");
Console.Write(place);
Console.Write(" are shocked and upset, having been instructed to stay put inside their homes until the ");
Console.Write(adjective);
Console.Write(" culprit can be apprehended. ");
Console.Write("Authorities have good reason to believe that it could be a ");
Console.Write(animal);
Console.WriteLine(" on the loose and that anyone could be caught in the path of this terrible creature.");

Console.ReadKey();

