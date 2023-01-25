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
int findUneven(int[] array)
{
 int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        count = count + array[i];
        i++;
    }
    return count;
}


System.Console.WriteLine("Сумма чисел стоящих на нечетной позиции = " + findUneven(array));