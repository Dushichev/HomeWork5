/* Задача 37: Найдите произведение пар чисел в одномерном массиве.
 Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21*/

int[] myArray = { 2, 8, 26, 11, 3, 10, 7 };

for (var i = 0; i < myArray.Length; i++)
{

    Console.Write(" " + myArray[i]);
}
Console.WriteLine();

int[] myArray2 = new int[4];

for (var i = 0; i < myArray2.Length; i++)
{
    myArray2[0] = myArray[0] * myArray[6];
    myArray2[1] = myArray[1] * myArray[5];
    myArray2[2] = myArray[2] * myArray[4];
    myArray2[3] = myArray[3];

    Console.Write(" " + myArray2[i]);
}
