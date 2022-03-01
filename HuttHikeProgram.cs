// See https://aka.ms/new-console-template for more information

int x;

x = 0;

for (x = 0; x <= 100; x++) 
{
    if (x % 3 == 0)
    {
            Console.WriteLine("Hutt"); 
    }
    else if (x % 7 == 0)
    {
        Console.WriteLine("Hike");
    }
    else
    { 
        Console.WriteLine(x);
    }

    
}

Console.WriteLine("End.");

Console.ReadKey();
