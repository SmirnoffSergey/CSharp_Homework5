// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// // числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.Write("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.WriteLine(array[i]);
//     if (array[i] % 2 == 0) count++;
// }

// Console.WriteLine($"Количество чётных чисел в массиве равно {count}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// int sumOddNums = 0;
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().Next(-99, 99);
//     Console.WriteLine(array[i]);
// }
// for (int i = 0; i < size; i = i + 2) sumOddNums += array[i];
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sumOddNums}");





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите количество чисел в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// double[] array = new double[size];
// for (int i = 0; i < size; i++)
// {
//     array[i] = new Random().NextDouble() * 100;
//     Console.WriteLine(array[i]);
// }
// double min = array[0];
// double max = array[0];

// for (int i = 0; i < size; i++)
// {
//     if (array[i] < min) min = array[i];
//     else if (array[i] > max) max = array[i];
// }
// double diff = max - min;
// Console.WriteLine();
// Console.WriteLine ($"Разница равна: {Math.Round(diff, 2)}");