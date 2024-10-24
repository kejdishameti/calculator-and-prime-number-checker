// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter:\n1 for Calculator\n2 for Prime Number Checker");
string nr = Console.ReadLine();

if (nr == "1")
{
    Console.WriteLine("You choose the calculator");
    Thread.Sleep(1500);
    Console.WriteLine("Enter first number: ");
    double firstNum = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter:\n+ for adding\n- for subtracting\n* for multiplying\n/ for division");
    char operation = Console.ReadKey().KeyChar;
    Console.WriteLine();

    Console.WriteLine("Enter second number: ");
    double secondNum = Convert.ToDouble(Console.ReadLine());

    double result = 0;

    switch (operation)
    {
        case '+':
            result = firstNum + secondNum;
            break;
        case '-':
            result = firstNum - secondNum;
            break;
        case '*':
            result = firstNum * secondNum;
            break;
        case '/':
            if (secondNum != 0)
                result = firstNum / secondNum;
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return;
            }
            break;
        default:
            Console.WriteLine("Invalid operation");
            return;
    }
    Console.WriteLine($"Result: {result}");

}

else if (nr == "2")
{
    Console.WriteLine("You choose the prime number checker");
    Thread.Sleep(1500);
    Console.WriteLine("Enter a number to check if it is a prime number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 == 0 || num1 == 1)
    {
        Console.WriteLine(num1 + " is not prime number");
        Console.ReadLine();
    }
    else
    {
        for (int a = 2; a <= num1 / 2; a++)
        {
            if (num1 % a == 0)
            {
                Console.WriteLine(num1 + " is not prime number");
                return;
            }

        }
        Console.WriteLine(num1 + " is a prime number");
        Console.ReadLine();
    }
    
    
}

else
{
    Console.WriteLine("Unknown number");
}
