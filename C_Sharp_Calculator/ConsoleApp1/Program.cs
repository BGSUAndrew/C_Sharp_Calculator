int num1 = 0;
int num2 = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type a number, then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type another number and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an option");
Console.WriteLine("\tA - Add");
Console.WriteLine("\tS - Subtract");
Console.WriteLine("\tM - Multiply");
Console.WriteLine("\tD = Divide");
Console.Write("Your option?");

switch (Console.ReadLine())
{
    case "A":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "S":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "M":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "D":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.Write("Press any key to close");
Console.ReadKey();