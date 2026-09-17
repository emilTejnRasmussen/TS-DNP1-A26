namespace Ex2___Traffic_light;

public class Pedestrian
{
    private int id; 
    public Pedestrian(TrafficLight tl, int id)
    {
        this.id = id;
        tl.OnLightChange += ReactToLight;
    }
    
    private void ReactToLight(string color)
    {
        var result = $"Pedestrian {id} ";
        
        switch (color)
        {
            case "GREEN":
                result += " stops";
                break;
            case "YELLOW":
                result += " waits";
                break;
            case "RED":
                result += " crosses";
                break;
        }
        Console.WriteLine(result);
    }
}