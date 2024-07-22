Dictionary<string, float> numbers = Task1.CalculateNumbers(12, -25);

foreach (float number in numbers.Values)
{
    Console.WriteLine(number);
}