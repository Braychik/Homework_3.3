/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int [] num = new int[N];
for(int i = 1; i <= N; i++)
    num[i - 1] = Convert.ToInt32(Math.Pow(i, 3));
for(int i = 0; i < N; i++)    
Console.Write($" {num[i]} ");