using System.Text;

var s1 = GenerateRandomString();
var s2 = GenerateRandomString();
var s3 = GenerateRandomString();

Console.WriteLine($"{s1}:");
FindSums(s1);

Console.WriteLine($"{s2}:");
FindSums(s2);

Console.WriteLine($"{s3}:");
FindSums(s3);

return;

string GenerateRandomString()
{
    const string charValues = "abcdefghijklmnopqrstuvwxyz0123456789????";
    Random random = new();
    StringBuilder sb = new();

    for (var i = 0; i < 20; i++)
    {
        var randomIndex = random.Next(0, charValues.Length);
        sb.Append(charValues.ElementAt(randomIndex));
    }

    return sb.ToString();
}

void FindSums(string s)
{
    var parts = s.Split("?", StringSplitOptions.RemoveEmptyEntries);
    var sums = parts
        .Select(part => part
            .ToCharArray()
            .Where(char.IsDigit).Sum(c => c - '0'))
        .ToList();

    Console.WriteLine(string.Join(", ", sums));
}