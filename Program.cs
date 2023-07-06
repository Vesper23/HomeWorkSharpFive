//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


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
