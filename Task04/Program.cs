// Определить, присутствует ли в заданном массиве, некоторое число.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
Console.Write("Задайте размер массива: ");
int arrayLength = int.Parse(Console.ReadLine()??"0");
int [] array = new int [arrayLength];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,11);
}
Console.Write("Массив: " );
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
bool ContainsNumber(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      if (array[i] == number)
         return true;
   return false;      
}
Console.WriteLine();
if (ContainsNumber(array) == true)
{
   Console.Write($"В массиве есть число соответствующее {number} ");
}
else
{
   Console.Write($"В массиве нет числа соответсвующего {number} ");
}