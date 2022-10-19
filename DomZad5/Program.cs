Console.Clear();
int[] NewArray(int size, int min, int max)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(min, max + 1);
    }
    return mas;
}

//                                      Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
//    Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите длину массива:");
int num = int.Parse(Console.ReadLine()!);
int[] FirstArray = NewArray(num, 100, 999);
Console.WriteLine($"[{String.Join(" ", FirstArray)}]");
CountNum();

int CountNum()
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        if (FirstArray[i] % 2 == 0)
        {
            count++;
        }

    }
    Console.WriteLine($"В массиве {count} четных чисел");
    return count;
}


//                                      Задача 36:
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//                            стоящих на нечётных позициях.

Console.WriteLine("Введите длину массива:");
int num2 = int.Parse(Console.ReadLine()!);
int[] SecondArray = NewArray(num2, -100, 100);
Console.WriteLine($"[{String.Join(" ", SecondArray)}]");
SumNum();

int SumNum()
{
    int sum = 0;
    for (int i = 0; i < num2; i++)
    {
        if (i % 2 != 0)
        {
            sum = SecondArray[i] + sum;
        }
    }
    Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях равна {sum}");
    return sum;
}


//                                      Задача 38:
//  Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности,
// с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите длину массива:");
int num3 = int.Parse(Console.ReadLine()!);
int[] ThirdArray = NewArray(num3, -99, 99);
Console.WriteLine($"[{String.Join(" ", ThirdArray)}]");
Diff();

int Diff()
{
    int max = 0;
    int min = 0;

    for (int i = 0; i < num3; i++)
    {
        if (ThirdArray[i] > max) max = ThirdArray[i];
        if (ThirdArray[i] < min) min = ThirdArray[i];
    }

    int diff = max - min;
    Console.WriteLine($"Разница между максимальным значением [{max}] и минимальным значением массива [{min}] равна: [{diff}]");
    return diff;
}

