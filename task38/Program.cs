/*Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


/*int[] myArray = { 3, 22, 65, 73, 2, 120 };
int max = myArray.Max();
int min = myArray.Min();

int result = max - min;
Console.WriteLine(result);*/


double[] myArray = { 3.1, 22.2, 65, 73.5, 2.5, 120 };

var minElement = myArray[0];
var maxElement = myArray[0];

for (var i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < minElement)
    {
        minElement = myArray[i];

    }
}
Console.WriteLine(minElement + " является наименьшим элементом массива");

for (var i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > maxElement)
    {
        maxElement = myArray[i];

    }
}
Console.WriteLine(maxElement + " является наибольшим элементом массива");
double result = maxElement - minElement;
Console.WriteLine("разность между максимальным и минимальным елементами = " + result);