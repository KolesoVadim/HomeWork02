// Задать массив из 8 элементов и вывести их на экран.
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Enter {i+1} element of array: ");
    array[i] = int.Parse(Console.ReadLine()??"0");
}
Console.Write("Your array: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}