void NTwice(string a, int index)
{
    Console.WriteLine($"{a[..index]}{a[^index..]}");
}

NTwice("Hello", 2);
NTwice("Chocolate", 3);
NTwice("Chocolate", 1);