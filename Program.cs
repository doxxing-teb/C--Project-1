Console.WriteLine("Author: Agustin Ibarra");
Console.WriteLine("LICENSE: GNU General Public License v3.0");


double num1, num2, result;
char op;

Console.Write("Insert You Number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insert You Second Number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insert Operation (+, -, *, /): ");
op = Convert.ToChar(Console.ReadLine());

switch (op)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    default:
        Console.WriteLine("Operation Invalid");
        return;
}

Console.WriteLine("The Result Is: " + result);
Console.WriteLine("Thanks For Using My Calculator :)");