// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please, enter your age:");
string Userage = Console.ReadLine();
int Useragenum = 0;
    bool isAgenumber =Int32.TryParse(Userage, out Useragenum);
Console.WriteLine($"Parse result {isAgenumber}. User is {Useragenum} years old.");
if (isAgenumber)
{
    if (Useragenum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}
        
      

