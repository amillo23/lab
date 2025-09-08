using System.Drawing;
string input = Console.ReadLine();
int number =Convert.ToInt32(input);
if (number >= 90 && number <= 100)
{
    Console.WriteLine("A");
}

else if (number >= 70 && number <= 89)
{
    Console.WriteLine("B");
}
else if (number >= 50 && number <= 69)
{

    Console.WriteLine("C");
}
else if (number < 50 && number>0)
{

    Console.WriteLine("F");
}
else
{
    Console.WriteLine("Invalid");
}
