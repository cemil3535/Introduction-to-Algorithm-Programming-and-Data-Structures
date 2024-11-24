using System.Security.Principal;

int A = 10;
int B = 20;

Operations select = (Operations)(new Random().Next(1,4));

switch (select)
{
    case Operations.Sum:
        Console.WriteLine($"{A} + {B} = {A + B}");
        break;
    case Operations.Minus:
        Console.WriteLine($"{A} - {B} = {A - B}");
        break;
    case Operations.Multiply:
        Console.WriteLine($"{A} * {B} = {A * B}");
        break;
    case Operations.Divide:
        Console.WriteLine($"{A} / {B} = {A / B}");
        break;
    default:
        Console.WriteLine("\aGecersiz Islem!");
        break;
}


enum Operations
{
    Sum = 1,
    Minus = 2,
    Multiply = 3,
    Divide = 4
}







