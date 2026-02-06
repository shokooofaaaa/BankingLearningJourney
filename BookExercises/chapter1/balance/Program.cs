// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your balance: ");
string YourBalance = Console.ReadLine();

int.TryParse(YourBalance, out int balance);
Console.WriteLine($"Your balance is: {balance}");