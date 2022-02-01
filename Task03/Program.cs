// Написать программу замену элементов массива на противоположные.
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Enter {i+1} element of array: ");
    array[i] = int.Parse(Console.ReadLine()??"0");
}
for (int i = 0; i < array.Length; i++)
    array[i] = array[i] * -1;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}