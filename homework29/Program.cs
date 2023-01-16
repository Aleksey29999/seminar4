//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray (int sizeArray)
{
int[] array = new int[sizeArray];
Random rnd = new Random();
for (int i =0; i<array.Length; i++)
array[i] = rnd.Next(-100, 100);
return array;
}

Console.WriteLine("введите колличество элементов массива");
int arraySize = int.Parse(Console.ReadLine());
int[] array = CreateArray (arraySize);
Console.WriteLine(string.Join(",", array));