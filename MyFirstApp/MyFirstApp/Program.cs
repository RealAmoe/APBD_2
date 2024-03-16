// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("It's 18:27");
Console.WriteLine("It's 18:28");
Console.WriteLine("It's 18:29");

static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers1 = {1, 2, 3, 4};
double average = GetAverage(numbers1);
Console.WriteLine(average);


static double GetMax(int[] numbers)
{
    int maxValue = numbers[0];
    foreach (var number in numbers)
    {
        if (number > maxValue)
        {
            maxValue = number;
        }
    }

    return maxValue;
}
int[] numbers2 = {1, 2, 3, 4};
double max = GetMax(numbers2);
Console.WriteLine(max);