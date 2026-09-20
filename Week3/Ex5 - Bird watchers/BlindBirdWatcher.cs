namespace Ex5___Bird_watchers;

public class BlindBirdWatcher : BirdWatcher
{
    public BlindBirdWatcher(Bird bird) : base(bird)
    {
    }

    protected override string ReactToMateDance()
    {
        return "";
    }

    protected override string ReactToLoop()
    {
        return "";
    }

    protected override string ReactToFlap()
    {
        return "";
    }
}