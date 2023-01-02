int[] array = { 1, 3, 8, 3, 2 };
int sum = 0;
for (int i = 0; i <array.Length / 2; i++)
{
    sum += array[i] * array[array.Length - 1 - i];
}
 
Console.WriteLine(sum); 
