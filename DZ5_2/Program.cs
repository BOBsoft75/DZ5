// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int summa = 0;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10, 11);
}

for (int j = 0; j < size; j++)
{
    if (j % 2 != 0)
    {
        summa = summa + array[j];
    }
}
Console.Write("[{0}]", String.Join("; ", array));
Console.Write(" -> " + summa);