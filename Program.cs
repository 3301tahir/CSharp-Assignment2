Console.WriteLine("A C# Program that generates an array of random 2-digit integers and shuffles them.\n");
Console.Write("Enter size of generated array: ");

int size = int.Parse(Console.ReadLine());
int[] array = new int[size];


// Populate generated array with random integers from 10 to 99
Random _rand = new Random();
for (int i = 0; i < size; i++)
    array[i] = _rand.Next(10, 100);

Console.Write("Generated array: ");
foreach (int i in array)
    Console.Write(i.ToString() + " ");
Console.WriteLine();

// Fisher-Yates Shuffle Algorithm
for (int i = size - 1; i > 0; i--)
{
    int j = _rand.Next(0, i + 1);

    int temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

Console.Write("Shuffled array: ");
foreach (int i in array)
    Console.Write(i.ToString() + " ");
Console.WriteLine();
