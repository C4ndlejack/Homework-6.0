// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

using System;
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
    Random rand = new Random();
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 99);
        Console.Write(array[i] + " ");
    }
    int [] array2 = new int [0];
    if (n % 2 == 0)
    {
        array2 = new int [n / 2];
    }
    else
    {
        array2 = new int [n / 2 + 1];
    }
    int result = 0;
    int j = 0;
    int k = 1;
    while(j < array.Length - k)
    {
        result = array[j] * array[array.Length - k];
        array2[j] = result;
        j++;
        k++;
        if(j == array.Length - k)
        {
            result = array[j];
            array2[j] = result;
        }
    }    
    Console.WriteLine("");
    Console.Write("Новый массив: ");
    for(int m = 0; m < array2.Length; m++)
    {
        Console.Write(array2[m] + " ");
    }
}

