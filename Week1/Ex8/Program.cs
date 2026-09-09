void MakeOutWord(string outer, string inner)
{
    var midIndex = outer.Length / 2;
    Console.WriteLine($"{outer[..midIndex]}{inner}{outer[midIndex..]}");
}

MakeOutWord("<<>>", "Yay");
MakeOutWord("<<>>", "WooHoo");
MakeOutWord("[[]]", "word");