void PrintEvenUntilX(int x)
{
    for (int i = 0; i <= x; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

void PrintUnevenUntilX(int x)
{
    for (int i = 0; i <= x; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

void PrintDivisibleByYUntilX(int x, int y)
{
    for (int i = 0; i <= x; i++)
    {
        if (i % y == 0)
        {
            Console.WriteLine(i);
        }
    }
}


PrintEvenUntilX(10);
PrintUnevenUntilX(10);
PrintDivisibleByYUntilX(10, 3);