namespace Ex5___Bird_watchers;

public class Bird
{
    public Action<BirdActions> BirdActionChange { get; set; }
    
    private readonly BirdActions[] actions = [
        BirdActions.FLAPS,
        BirdActions.LOOP,
        BirdActions.MATING_DANCE,
        BirdActions.SINGS
    ];
    
    private const int ActionsToRun = 10;
    
    public void RunBirdSim()
    {
        Random random = new();
        
        for (var i = 0; i < ActionsToRun; i++)
        {
            var index = random.Next(0, actions.Length);
            var action = actions[index];
            
            Console.WriteLine(action.GetDescription());
            
            BirdActionChange.Invoke(action);
            
            Thread.Sleep(1500);
        }
    }
}