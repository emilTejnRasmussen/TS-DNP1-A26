int BigDiff(int[] numbers)
{
    return numbers.Max() - numbers.Min();
}

Console.WriteLine(BigDiff([10, 3, 5, 6]));
Console.WriteLine(BigDiff([7, 2, 10, 9]));
Console.WriteLine(BigDiff([2, 10, 7, 2]));