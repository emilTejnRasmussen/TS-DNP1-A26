namespace Ex5___Bird_watchers;

public class JutlandicBirdWatcher : BirdWatcher
{
    public JutlandicBirdWatcher(Bird bird) : base(bird)
    {
    }

    protected override string ReactToSinging()
    {
        return "its ok i guess..";
    }

    protected override string ReactToMateDance()
    {
        return "pff..";
    }

    protected override string ReactToLoop()
    {
        return "ok.";
    }

    protected override string ReactToFlap()
    {
        return "so unique..";
    }
}