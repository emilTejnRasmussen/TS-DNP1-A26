using Ex4___Car_and_predicates;

var generatedCars = generateCars();

// PrintCarsOfColor(generatedCars, "Red");
// PrintCarsOfColors(generatedCars, "Red", "Purple");
// PrintCarsWithHpHigherThan(generatedCars, 350);
// PrintCarsWithHpBetween(generatedCars, 200, 250);
// PrintCarsWithFuelEconomyLowerThan(generatedCars, 6);

PrintCarsWithMatchingConditions(
    generatedCars,
    car => car.Color == "Red",
    car => car.HorsePower > 250
);

return;

void PrintCarsWithMatchingConditions(List<Car> cars, Func<Car, bool> conditionA, Func<Car, bool> conditionB)
{
    cars.Where(conditionA)
        .Where(conditionB)
        .ToList()
        .ForEach(PrintCar);
}

void PrintCarsWithFuelEconomyLowerThan(List<Car> cars, int upperFuelLimit)
{
    Console.WriteLine("____________________________________");

    cars.Where(car => car.FuelEconomy < upperFuelLimit)
        .ToList()
        .ForEach(PrintCar);
}

void PrintCarsWithHpBetween(List<Car> cars, int lower, int upper)
{
    Console.WriteLine("____________________________________");

    cars.Where(car => car.HorsePower > lower && car.HorsePower < upper)
        .ToList()
        .ForEach(PrintCar);
}

void PrintCarsWithHpHigherThan(List<Car> cars, int hp)
{
    Console.WriteLine("____________________________________");

    cars.Where(car => car.HorsePower > hp)
        .ToList()
        .ForEach(PrintCar);
}

void PrintCarsOfColors(List<Car> cars, string colorA, string colorB)
{
    Console.WriteLine("____________________________________");

    cars.Where(car => car.Color == colorA || car.Color == colorB)
        .ToList()
        .ForEach(PrintCar);
}

void PrintCarsOfColor(List<Car> cars, string color)
{
    Console.WriteLine("____________________________________");

    cars.Where(car => car.Color == color)
        .ToList()
        .ForEach(PrintCar);
}

List<Car> generateCars()
{
    List<Car> listOfCars = [];

    for (var i = 0; i < 20; i++)
    {
        listOfCars.Add(GenerateCar());
    }

    return listOfCars;
}

Car GenerateCar()
{
    Random random = new();
    string[] colors = ["Red", "Yellow", "Black", "Gray", "Purple", "Orange"];

    var color = colors[random.Next(0, colors.Length)];
    var horsePower = random.Next(80, 400);
    var fuel = random.Next(5, 12);
    var shift = random.Next(0, 2) == 1 ? true : false;

    return new Car
    {
        Color = color,
        HorsePower = horsePower,
        FuelEconomy = fuel,
        IsManualShift = shift
    };
}

void PrintCar(Car car)
{
    Console.WriteLine(car);
    Console.WriteLine("____________________________________________");
}