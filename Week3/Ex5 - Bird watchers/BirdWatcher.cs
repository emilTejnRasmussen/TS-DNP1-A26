namespace Ex5___Bird_watchers;

public class BirdWatcher
{
    public BirdWatcher(Bird bird)
    {
        bird.BirdActionChange += ReactToActionChange;
    }

    private void ReactToActionChange(BirdActions action)
    {
        string reaction = action switch
        {
            BirdActions.FLAPS => ReactToFlap(),
            BirdActions.LOOP => ReactToLoop(),
            BirdActions.MATING_DANCE => ReactToMateDance(),
            BirdActions.SINGS => ReactToSinging()
        };

        Console.WriteLine($"Bird watcher says: '{reaction}'");
    }

    protected virtual string ReactToSinging()
    {
        return "How nice";
    }

    protected virtual string ReactToMateDance()
    {
        return "Would you look at that";
    }

    protected virtual string ReactToLoop()
    {
        return "A LOOP-DI-LOOP";
    }

    protected virtual string ReactToFlap()
    {
        return "Ooh";
    }
}