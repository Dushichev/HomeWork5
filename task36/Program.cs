/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


Console.WriteLine("введите размер массива ");
int size = int.Parse(Console.ReadLine());
int[] myArray = GetArray(size);
PrintArray(myArray);

int[] GetArray(int num)
{
    Random rnd = new Random();
    int sum = 0;
    int[] array = new int[num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 15);
        Console.WriteLine("Индекс = " + i + " ----> число = " + array[i]);
        if (i % 2 != 0)
        {
            sum += array[i];
        }

    }
    Console.WriteLine();
    Console.WriteLine("сумма элементов,находящихся на нечётной позиции = " + sum);
    Console.WriteLine();
    return array;






}

void PrintArray(int[] array)

{

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(" число " + array[i] + " находится на нечётной позиции ");
        }
    }

}