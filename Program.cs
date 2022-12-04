// Семинар 1. Знакомство.

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad = num2 * num2;

if(num1 == quad)
    Console.WriteLine("Верно");
else
    Console.WriteLine("Не верно");
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.
 
/*
Console.Write("Input an integer number : ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

// Задача 3: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.Write("MAX = " + num1 + " " + "MIN =  " + num2);
else
    Console.Write($"MAX = {num2} MIN = {num1}");
*/

// Задача 4:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* 
Console.Write("Input a first number : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number : ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max) max = num2;
{
    if(num3 > max) max = num3;
    Console.Write ("MAX = " + max);
}
*/

// Задача 5: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number : ");
int num = Convert.ToInt32(Console.ReadLine());

if(num %2 == 0) 
Console.WriteLine("Число четное");
else
Console.WriteLine("Число не четное");
*/

// Задача 6: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a number : ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= n) 
{
 if(current %2 == 0)
 Console.Write(current + " ");
 current++;
}
*/

