//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using System;
{
    int [] array = new int [123];
    Random rand = new Random();
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 1000);
        Console.Write(array[i] + " ");
    }
    int count = 0;
    foreach(int j in array)
    {
        if (j >= 10 & j <= 99)
        count++;
    }
    Console.WriteLine("");
    Console.WriteLine("Количество элементов массива в отрезке [10, 99] - " + count);
}