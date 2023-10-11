System.Console.WriteLine("Console Calculator");
System.Console.WriteLine("Possible operations: '+','-','*','/'");
System.Console.WriteLine("Enter the first number");
double num1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Enter the operation sign");
char operSign = Convert.ToChar(Console.ReadLine());
System.Console.WriteLine("Enter the second number");
double num2 = Convert.ToDouble(Console.ReadLine());
double result = 0;
if (operSign == '+')
{
    result = num1 + num2;
}
if (operSign == '-')
{
    result = num1 - num2;
}
if (operSign == '*')
{
    result = num1 * num2;
}
if (operSign == '/')
{
    if (num2 != 0) result = num1 / num2;
}
if (operSign == '^')
{
    result = Math.Pow(num1,num2);
}
if (num2 == 0) Console.WriteLine("Division by zero error");
else Console.WriteLine("The result is " + result);
Console.ReadLine();
