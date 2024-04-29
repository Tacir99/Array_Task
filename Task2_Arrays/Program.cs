
Console.Write("Enter the number of elements of the first array: ");
int arraySizeOne = int.Parse(Console.ReadLine());
int[] numbers = new int[arraySizeOne];

Console.Write("Enter the number of elements of the second array: ");
int arraySizeTwo = int.Parse(Console.ReadLine());
int[] numbers2 = new int[arraySizeTwo];

var random = new Random();
Console.WriteLine("Array One: ");
for (int i = 0; i < arraySizeOne; i++)
{
    numbers[i] = random.Next(100);
}

foreach (var number in numbers)
{
    Console.WriteLine($"{number}  ");
}
Console.WriteLine("Array Two: ");
for (int i = 0; i < arraySizeTwo; i++)
{
    numbers2[i] = random.Next(100);
}

foreach (var number in numbers2)
{
    Console.WriteLine($"{number}  ");
}

int newSize = 0;
foreach (int element in numbers)
{
    if (element % 2 == 0)
    {
        newSize++;
    }
}
foreach (int element in numbers2)
{
    if (element % 2 != 0)
    {
        newSize++;
    }
}

int[] newArray = new int[newSize]; 

int index = 0;


foreach (int element in numbers)
{
    if (element % 2 == 0)
    {
        newArray[index] = element;
        index++;
    }
}


foreach (int element in numbers2)
{
    if (element % 2 != 0)
    {
        newArray[index] = element;
        index++;
    }
}


Console.WriteLine("New Array: ");
foreach (int element in newArray)
{
    Console.Write(element + " ");
}
