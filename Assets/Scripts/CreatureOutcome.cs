using System.Collections;
using System.Collections.Generic;

public class CreatureOutcome
{
    public string name {get;}
    public bool is_good {get;}

    public CreatureOutcome(string name,
                           bool is_good)
    {
        this.name = name;
        this.is_good = is_good;
    }
}

public static class CREATURE_OUTCOMES
{
    public static CreatureOutcome STARVE = new CreatureOutcome(
        "starve",
        false
    );
    public static CreatureOutcome SUFFOCATE = new CreatureOutcome(
        "suffocate",
        false
    );
    public static CreatureOutcome DROWN = new CreatureOutcome(
        "drown",
        false
    );
    public static CreatureOutcome FLY = new CreatureOutcome(
        "fly",
        true
    );
    public static CreatureOutcome REACH_TREE = new CreatureOutcome(
        "reach_tree",
        true
    );
    public static CreatureOutcome HEAD_HIT_TREE = new CreatureOutcome(
        "head_hit_tree",
        true
    );
    public static CreatureOutcome BACK_HIT_TREE = new CreatureOutcome(
        "back_hit_tree",
        true
    );
    public static CreatureOutcome TAIL_HIT_TREE = new CreatureOutcome(
        "tail_hit_tree",
        true
    );
    public static CreatureOutcome FREEZE = new CreatureOutcome(
        "freeze",
        false
    );
    public static CreatureOutcome BURN = new CreatureOutcome(
        "burn",
        false
    );
}