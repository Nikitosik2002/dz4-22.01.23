System.Console.WriteLine("Введите размерность массива ");
int r = Convert.ToInt32(Console.ReadLine());

int[] array = new int[r];
var rnd = new Random();

void fill (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}
void print (int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}
fill(array);
print(array);
System.Console.WriteLine();

int even (int[] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
return count;
}

System.Console.WriteLine( "Четных чисел в массиве " + even(array));