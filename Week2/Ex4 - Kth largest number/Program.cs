int[] ia1 = [6, 3, 5, 9, 1, 2];
int[] ia2 = [1, 3, 0, 4, 2, 1, 3];

var rs1 = Largest(ia1, 2);
var rs2 = Largest(ia1, 1);
var rs3 = Largest(ia2, 4);

Console.WriteLine(rs1);
Console.WriteLine(rs2);
Console.WriteLine(rs3);

return;


int Largest(int[] ints, int k)
{
    ArgumentOutOfRangeException.ThrowIfLessThan(k, 1);

    var set = new HashSet<int>(ints);
    var list = set.ToList();

    ArgumentOutOfRangeException.ThrowIfGreaterThan(k, list.Count);

    list.Sort();

    return list[^k];
}