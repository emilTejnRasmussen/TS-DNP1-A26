namespace Ex2___Traffic_light;

public class Taxi
{
    private int id; 
    public Taxi(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    
    private void ReactToLight(string color)
    {
        var result = $"Taxi {id} ";
        
        switch (color)
        {
            case "GREEN":
                result += " drives";
                break;
            case "YELLOW":
                result += " speeds up  -  'TAXI GREEN'";
                break;
            case "RED":
                result += " stops";
                break;
        }
        Console.WriteLine(result);
    }
}