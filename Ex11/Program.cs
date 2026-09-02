void CountClumps(int[] numbers)
{
    var amount = 0;
    var isSameClump = false;

    for (var i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] == numbers[i - 1] && !isSameClump)
        {
            amount++;
            isSameClump = true;
        }

        else if (numbers[i] != numbers[i - 1])
        {
            isSameClump = false;
        }
    }

    Console.WriteLine(amount);
}

CountClumps([1, 2, 2, 3, 4, 4]);
CountClumps([1, 1, 2, 1, 1]);
CountClumps([1, 1, 1, 1, 1]);