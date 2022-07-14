//  Задача 2: Написать программму, котора принимает на вход три числа и выдает максимальное из этих чисел.

int a = 3;
int b = 1;
int c = 10;
int max = a;

if (b>max) max = b;
if (c>max) max = c;
Console.Write(max);