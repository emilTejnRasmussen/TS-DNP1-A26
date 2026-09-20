namespace Ex4___Car_and_predicates;

public class Car
{
    public required string Color { get; set; }
    public required int HorsePower { get; set; }
    public required int FuelEconomy { get; set; }
    public required bool IsManualShift { get; set; }


    public override string ToString()
    {
        var shift = IsManualShift ? "Manual" : "Auto";
        return $"""
               Color:          {Color} 
               Horse power:    {HorsePower} 
               Fuel Economy:   {FuelEconomy} liters per 100km
               Shift:          {shift} 
               """;
    }
}