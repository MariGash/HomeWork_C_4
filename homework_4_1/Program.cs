/* Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int P = 1;
while (i < B)
{
    P = P * A;
    i++;
}
Console.WriteLine(A + " в степени " + B + " равно " + P);