// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите число элементов массива трехзначных чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int count =0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int j = 0; j < size; j++)
{
    if (array[j] % 2 == 0)
    {
        count++;
    }
}

Console.Write("[{0}]", String.Join("; ", array));
Console.Write(" -> " + count);