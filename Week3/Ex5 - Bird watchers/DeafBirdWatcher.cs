namespace Ex5___Bird_watchers;

public class DeafBirdWatcher : BirdWatcher
{
    public DeafBirdWatcher(Bird bird) : base(bird)
    {
    }

    protected override string ReactToSinging()
    {
        return "";
    }
}