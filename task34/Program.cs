/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.WriteLine("Ввведите длинну массива");
int number = int.Parse(Console.ReadLine());
int[] arr = GetArray(number);
//PrintArray(arr);


int[] GetArray(int n)
{
    int count = 0;
    int[] arr = new int[n];
    Random rnd = new Random();


    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 1000);
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        if (arr[i] % 2 == 0)

        {
            count++;
            int sum = arr[i];
            Console.WriteLine("число " + sum + " является четным");
        }


    }
    Console.WriteLine($"четных чисел: {count}");
    return arr;


}

/*void PrintArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}*/
