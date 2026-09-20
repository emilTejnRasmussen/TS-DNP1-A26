using System.ComponentModel;
using System.Reflection;

namespace Ex5___Bird_watchers;

public enum BirdActions
{
    FLAPS,
    LOOP,
    SINGS,
    MATING_DANCE
}

public static class BirdActionExtensions
{
    public static string GetDescription(this BirdActions birdAction)
    {
        return birdAction switch
        {
            BirdActions.FLAPS => "Bird flaps wings",
            BirdActions.LOOP => "Bird does a loop-di-loop",
            BirdActions.MATING_DANCE => "Bird does a mating dance",
            BirdActions.SINGS => "Bird sings",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}