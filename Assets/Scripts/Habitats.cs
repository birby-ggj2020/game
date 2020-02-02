using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO: pull name/background_img out to a config; only hardcode actual code.
public interface Habitat
{
    string name {get;}
    string background_img_path {get;}
    CreatureOutcome creature_outcome(Creature creature);
}

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

public class GrasslandsHabitat : Habitat
{
    public string name
    {
        get => "Grasslands";
    }

    public string background_img_path
    {
        get => "Assets/Graphics/grasslands.png";
    }

    public CreatureOutcome creature_outcome(Creature creature)
    {
        if (creature.head.name == "fish")
        {
            return CREATURE_OUTCOMES.SUFFOCATE;
        }
        if (creature.head.name == "brontosaurus")
        {
            return CREATURE_OUTCOMES.REACH_TREE;
        }
        if (creature.head.name == "centaur")
        {
            return CREATURE_OUTCOMES.HEAD_HIT_TREE;
        }
        if (creature.back.name == "tank")
        {
            return CREATURE_OUTCOMES.BACK_HIT_TREE;
        }
        if (creature.back.name == "batwings"
            || creature.back.name == "birdwings"
            || creature.tail.name == "propeller")
        {
            return CREATURE_OUTCOMES.FLY;
        }
        if (creature.tail.name == "thagomizer")
        {
            return CREATURE_OUTCOMES.TAIL_HIT_TREE;
        }
        return CREATURE_OUTCOMES.STARVE;
    }
}

public class TundraHabitat : Habitat
{
    public string name
    {
        get => "Tundra";
    }

    public string background_img_path
    {
        get => "Assets/Graphics/snow.png";
    }

    public CreatureOutcome creature_outcome(Creature creature)
    {
        //TODO
        return CREATURE_OUTCOMES.FREEZE;
    }
}

public class ShoreHabitat : Habitat
{
    public string name
    {
        get => "Shore";
    }

    public string background_img_path
    {
        get => "Assets/Graphics/shore.png";
    }

    public CreatureOutcome creature_outcome(Creature creature)
    {
        //TODO
        return CREATURE_OUTCOMES.DROWN;
    }
}

public class DesertHabitat : Habitat
{
    public string name
    {
        get => "Desert";
    }

    public string background_img_path
    {
        get => "Assets/Graphics/desert.png";
    }

    public CreatureOutcome creature_outcome(Creature creature)
    {
        //TODO
        return CREATURE_OUTCOMES.BURN;
    }
}