// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int GetExp(int num)
{
    int res  = numA;
    for( int i = 1; i < numB; i++)
    res  = res * numA;
    return res;    
}
 int result = GetExp(numB);
 Console.Write("A в степени B = ");
 Console.Write(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 0) numA = -numA;

int GetSum(int numA)
{
    int sum = 0;

    while (numA > 0)
    {
        sum = sum + (numA % 10);
        numA = numA / 10;
    }
    return sum;
}
int result = GetSum(numA);
Console.Write("Сумма цифр в числе = ");
Console.WriteLine(result);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Массив: ");
Console.Write("[ ");
for (int i = 0; i < 8; i++)
{
    Console.Write(Array[i] + " ");
}
Console.Write("]");
