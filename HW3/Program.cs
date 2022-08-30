// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да


string input = Console.ReadLine();
bool GetRev(string input)
{
    if((new string(input.Reverse().ToArray())) == input)
    return true;
    return false;
}

bool result = GetRev(input);
if(result == true)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату x первой точки: ");
bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
Console.Write("Введите координату y первой точки: ");
bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);
Console.Write("Введите координату z первой точки: ");
bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

Console.Write("Введите координату x второй точки: ");
bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
Console.Write("Введите координату y второй точки: ");
bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);
Console.Write("Введите координату z второй точки: ");
bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);



// // if(!isNumberX_1 || !isNumberX_2 || isNumberY_1 || isNumberY_2)
// // {
// //     Console.WriteLine("Числа введены неверно");
// //     return;
// // }
Console.Write($"Расстояние: {GetLenght(x1, y1, z1, x2, y2, z2)}");

double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}



// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for( int i = 1; i <= N; i++)
{
    // Console.WriteLine($"{i * i * i}"); 
    Console.WriteLine(Math. Pow(i,3));
}