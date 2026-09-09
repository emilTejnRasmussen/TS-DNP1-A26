namespace Ex5.MathLib;

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static int Add(int[] numbers)
    {
        var sum = 0;

        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum;
    }

    public static int maxInput()
    {
        int a = GetIntegerInput();
        int b = GetIntegerInput();
        
        return Math.Max(a, b);
    }

    private static int GetIntegerInput()
    {
        int num;
        
        while (true)
        {
            Console.Write("Input an integer: ");
            var input = Console.ReadLine();
            
            if (int.TryParse(input, out num))
            {
                break;
            }
            Console.WriteLine("That was not an integer now was it..");
        }

        return num;
    }
}