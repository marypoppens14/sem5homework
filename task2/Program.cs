// Задать одномерный массив, заполненный случайными числами
// Найти сумму элементов, стоящих на нечётных позициях

int[] GenArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}

int[] array = GenArray(10);
int Sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i %2 != 0)
    {
        Sum += array[i];
    }
}

Console.WriteLine($"Сумма равна {Sum}");