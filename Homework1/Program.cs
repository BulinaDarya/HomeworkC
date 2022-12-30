//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int max = 0;
int min = 0;

Console.Write("Input first Number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
   max = firstNumber;
   min = secondNumber;
}
else
{
   max = secondNumber;
   min = firstNumber;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



int max = 0;

Console.Write("Input first Number");
int firstNumber= Convert.ToInt32(Console.ReadLine());

Console.Write("Input second Number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third Number ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > max)
{
   max = firstNumber;
}
if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
   max = thirdNumber;
}

Console.WriteLine("max = " + max);




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

int  ToInt32 = number % 2;

if(ToInt32 == 0)
{
   Console.WriteLine("Yes");
}
else
{
   Console.WriteLine("No");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Input  number");
int N = Convert.ToInt32(Console.ReadLine());

int Number = 2;

if(N > 1)
{
   while(Number <= N)
   {
      Console.Write(Number + " ");
       Number = Number + 2;
    }
}