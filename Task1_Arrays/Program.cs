
Console.Write("Enter the number of elements of the array: ");
int arraySize = int.Parse(Console.ReadLine());
int[] numbers = new int[arraySize];

var random = new Random();

for (int i = 0; i < arraySize; i++)
{
    numbers[i] = random.Next(100);
}

foreach (var number in numbers)
{
    Console.Write($"{number}  ");
}

#region Ascending order

for (int i = 0; i < arraySize - 1; i++)
{
    for (int j = i + 1; j < arraySize; j++)
    {
        if (numbers[i] > numbers[j])
        {
            int orderAsc = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = orderAsc;
        }
    }

}
Console.Write("\nAscending order:  ");
foreach (var item in numbers)
{
    Console.Write(item + " ");
}

#endregion

#region Descending order
for (int i = 0; i < arraySize - 1; i++)
{
    for (int j = i + 1; j < arraySize; j++)
    {
        if (numbers[i] < numbers[j])
        {
            int orderDes = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = orderDes;
        }
    }

}
Console.Write("\nDescending order:  ");
foreach (var item in numbers)
{
    Console.Write(item + " ");
}
#endregion

#region Maximum Element
void maxNum()
{
    int max = numbers[0];
    for (int i = 0; i < arraySize; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }

    }
    Console.WriteLine($"\nThe maximum element of the array: {max}");
}

maxNum();

void maxNumSecond()
{
    int max = numbers[0];
    for (int i = 0; i < arraySize; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }

    }
    int secondMax = 0;
    for (int i = 0; i < arraySize; i++)
    {
        if (numbers[i] != max && numbers[i] > secondMax)
        {
            secondMax = numbers[i];
        }
    }
    Console.WriteLine($"\nThe second maximum element of the array: {secondMax}");
}
maxNumSecond();
#endregion

#region Minimum Element

void minNum()
{
    int min = numbers[0];
    for (int i = 0; i < arraySize; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }

    }
    Console.WriteLine($"\nThe minimum element of the array: {min}");
}
minNum();
#endregion



#region IndexOf


int sum = 0;
int total = 1;

for (int i = 0; i < arraySize; i++)
{
    if (i != 0)
    {
        if (i % 2 == 0)
        {
            total = total * numbers[i];
        }
        else
        {
            sum = sum + numbers[i];
        }

    }
}

Console.WriteLine($"\nSum of elements with odd indices: {sum}");
Console.WriteLine($"\nMultiplication of elements with even indices: {total}");

#endregion


#region Average
void avgNumbers()
{
    double sum = 0;
    for (int i = 0; i < arraySize; i++)
    {
        sum += numbers[i];
    }
    Console.WriteLine($"\nAverage number of array: {sum / arraySize}");
}

avgNumbers();
#endregion

