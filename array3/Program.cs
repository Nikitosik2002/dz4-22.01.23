System.Console.WriteLine("Введите размерность массива ");
int r = Convert.ToInt32(Console.ReadLine());

int[] array = new int[r];
var rnd = new Random();

void fill (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
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
int maxMin(int[] array)
{
int result = 0;
int max = array[0];
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
    
    if (max < array[i])
    {
        max = array[i];
    }

    if (min > array[i])
    {
        min = array[i];
    }

result = max - min;
}
return result;
}

System.Console.WriteLine( "Разница между максимальным и минимальным эллементом массива составляет " + maxMin(array));
