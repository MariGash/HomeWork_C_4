/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.
452 -> 6
82 -> 2
9012 -> 3
*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = N;
int sum = 0;
while (num > 0)
{
    int a = num % 10;
    if(a != 0 && 0 == N % a)
    {
        sum = sum + a;
    }
    num = num / 10;
}
Console.WriteLine(sum);

