/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
string num = Convert.ToString(N);
if(num[0] == num[4] && num[1] == num[3])
{
Console.WriteLine($"Число {N} является палиндромом");
}else
{
    Console.WriteLine("не является палиндромом");
}

//int n = N % 10000;
//int m = N % 100;
/*if(N / 10000 == N % 10 && n / 1000 == m / 10)
Console.WriteLine($"Число {N} является палиндромом");
else
{
    Console.WriteLine("не является палиндромом");
}*/

