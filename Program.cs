﻿//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) //Создание массива
{
    return new int[size];
}

void FillArray(int[] array, int min, int max) //Заполнение массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);
}

int CountChetChisel(int[] array) //Кол-во четных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

void PrintArray(int[] array) //Вывод массива на экран
{
    Console.Write("Ваш массив: ");
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}


int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int [] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
int result = CountChetChisel(myArray);

PrintArray(myArray);
Console.WriteLine($"Количество чётных чисел в массиве: {result}");
*/

//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size) //Создание массива
{
    return new int[size];
}

void FillArray(int[] array, int min, int max) //Заполнение массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(min, max + 1);
}

void PrintArray(int[] array) //Вывод массива на экран
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

int SumElements(int[] array) //Сумма элементов массива на нечетных позициях
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = InputNum("Введите размер массива: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int [] myArray = CreateArray(size);
FillArray(myArray, minValue, maxValue);
int result = SumElements(myArray);

PrintArray(myArray);
Console.WriteLine($"Сумма элементов нечетных позиций массива: {result}");
*/

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size) //Создание массива вещественных чисел
{
    return new double[size];
}

void FillArray(double[] array) //Заполнение массива вещественными числами
{
    int rand = new Random().Next(101);
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(rnd.NextDouble() * rand, 2);
}

void PrintArray(double[] array) //Вывод массива на экран
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

double Differ(double[] array) //Разница между максимальным и минимальным элементом массива
{
    double max = array[0], min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max - min;
}

int size = InputNum("Введите размер массива: ");

double [] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
double result = Differ(myArray);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}");