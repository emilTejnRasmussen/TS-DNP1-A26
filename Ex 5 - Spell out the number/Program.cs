using System.Text;

SpellOutNumber(0);
SpellOutNumber(1);
SpellOutNumber(157);
SpellOutNumber(23831);
SpellOutNumber(23831435);
SpellOutNumber(2383162346);

return;

void SpellOutNumber(long n)
{
    var numInWords = new NumberInWords(n);
    Console.WriteLine(numInWords.ToWords());
}


class NumberInWords(long value)
{
    private long Value { get; } = value;

    private NumberGroup UnitsGroup { get; } = new NumberGroup((int)(value % 1000), NumberScale.None);
    private NumberGroup ThousandsGroup { get; } = new NumberGroup((int)(value / 1_000 % 1000), NumberScale.Thousand);
    private NumberGroup MillionsGroup { get; } = new NumberGroup((int)(value / 1_000_000 % 1000), NumberScale.Million);
    private NumberGroup BillionsGroup { get; } = new NumberGroup((int)(value / 1_000_000_000 % 1000), NumberScale.Billion);

    public string ToWords()
    {
        if (Value == 0) return "zero";
        
        StringBuilder sb = new();

        if (BillionsGroup.Value != 0) sb.Append(BillionsGroup.ToWords()).Append(' ');
        if (MillionsGroup.Value != 0) sb.Append(MillionsGroup.ToWords()).Append(' ');
        if (ThousandsGroup.Value != 0) sb.Append(ThousandsGroup.ToWords()).Append(' ');
        if (UnitsGroup.Value != 0) sb.Append(UnitsGroup.ToWords());

        return sb.ToString().TrimEnd();
    }
}

class NumberGroup(int value, NumberScale scale)
{
    public int Value { get; } = value;
    private NumberScale Scale { get; } = scale;

    public string ToWords()
    {
        StringBuilder sb = new();
        var hundreds = Value / 100;
        var remainder = Value % 100;

        if (hundreds > 0)
        {
            sb.Append(Ones[hundreds]).Append(" hundred");
            if (remainder > 0) sb.Append(" and ");
        }

        if (IsTeen(remainder)) sb.Append(Teens[remainder - 10]);
        else if (remainder > 0)
        {
            var tens = remainder / 10;
            var ones = remainder % 10;

            if (tens > 0)
                sb.Append(Tens[tens]);

            if (tens > 0 && ones > 0)
                sb.Append(' ');

            if (ones > 0)
                sb.Append(Ones[ones]);
        }

        if (Scale != NumberScale.None)
        {
            sb.Append(' ').Append(Scale.ToString().ToLower());
        }

        return sb.ToString();
    }

    private static bool IsTeen(int remainder)
    {
        return remainder is >= 10 and < 20;
    }

    private static readonly string[] Ones =
    [
        "", "one", "two", "three", "four",
        "five", "six", "seven", "eight", "nine"
    ];

    private static readonly string[] Teens =
    [
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
    ];

    private static readonly string[] Tens =
    [
        "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
    ];
}

enum NumberScale
{
    None,
    Thousand,
    Million,
    Billion
}