// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее

/*Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine("Большее число  "+ number1 + ", меньшее " + number2);
}
else {
    if (number1 < number2)
    {
       System.Console.WriteLine("Большее число  "+ number2 + ", меньшее " + number1); 
    }
    else {
        System.Console.WriteLine("Числа равны"); 
    }
}*/

// ЗАДАЧА 2
//Напишите программу, которая принимает на вход 3 числа
// и выдает максимальное из этих чисел

/*Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max_number=number1;
if (number2 > max_number)
{
    max_number = number2;
}
if (number3 > max_number)
{
    max_number = number3;
}
System.Console.WriteLine("Максимальное число " + max_number);*/


// ЗАДАЧА 3
// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка)

/*Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    System.Console.WriteLine("Число четное");
}
else
{
    System.Console.WriteLine("Число нечетное");
}*/

// ЗАДАЧА 4
// Напишите программу, котрая на вход принимает число (N), 
// а на выходе показвает все четные числа от 1 до N

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 1)
{
    Console.WriteLine("Таких чисел нет");
}
else 
{
    int i=2;
    while (i <= number)
    {
        Console.Write(i + ", ");
        i += 2;
    }
}
