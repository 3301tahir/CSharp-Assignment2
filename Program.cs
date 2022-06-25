// See https://aka.ms/new-console-template for more information

int size = 10;
int[] array = new int[size];
Random _rand = new Random();

for (int i = 0; i < size; i++)
    array[i] = _rand.Next(10, 100);

foreach (int i in array)
    Console.Write(i.ToString() + " ");
Console.WriteLine();

for(int i = size - 1; i > 0; i--)
{
    int j = _rand.Next(0, i + 1);

    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

foreach (int i in array)
    Console.Write(i.ToString() + " ");
Console.WriteLine();
