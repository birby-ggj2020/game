using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabitatState
{
    public Habitat habitat {get;}
    public Creature creature {get;}

    public HabitatState(Habitat hab)
    {
        this.habitat = hab;
        this.creature = new Creature();
    }

    public bool creature_is_correct()
    {
        return this.habitat.creature_is_correct(this.creature);
    }
}

public static class GameState
{
    public static List<HabitatState> habitats;
    public static int? active_habitat_index;
    public static List<CreaturePart> creature_parts;
    // public static Dictionary<CreaturePartType, List<CreaturePart> > creature_parts_by_type;

    static GameState()
    {
        GameState.habitats = new List<HabitatState>{
            new HabitatState(new GrasslandsHabitat()),
            new HabitatState(new TundraHabitat())
        };
        GameState.active_habitat_index = null;

        GameState.creature_parts = new List<CreaturePart>{
            new CreaturePart(
                "LongNeck",
                CreaturePartType.HEAD,
                Resources.Load("Assets/Graphics/creature_parts/Exquisite_Small-24.png") as Sprite
            )
        };
    }
}
