// Задать массив, заполненный случайными положительными трёхзначными числами
// Написать программу, которая покажет количество чётных чисел в массиве

int[] GenArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    Console.WriteLine(String.Join(",", array));
    return array;
}

int[] array = GenArray(10);
for (int i = 0; i < 10; i++)
{
    if (array[i]%2 == 0)
    {
        Console.WriteLine(array[i]);
    }
}
