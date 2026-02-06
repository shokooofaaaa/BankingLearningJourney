// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Banking App");
Console.WriteLine("Enter your name: ");

string name = Console.ReadLine();
if (name == null)
{
    Console.WriteLine("Name cannot be null");
}
else
{
    Console.WriteLine($"Hello, {name}! welcome");
}

