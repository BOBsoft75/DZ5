// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double maxElement = 0;
double minElement = 0;
double diff = 0;
double[] array = new double[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10, 11);
}

if (array[0] > array[1])
{
    maxElement = array[0];
    minElement = array[1];
}

for (int j = 0; j < size; j++)
{
    if (array[j] > maxElement)
    {
        maxElement = array[j];
    }
    else
    {
        if (array[j] < minElement)
        {
            minElement = array[j];
        }
    }
}
diff = maxElement - minElement;
Console.Write("[{0}]", String.Join("; ", array));
Console.Write(" -> " + diff);