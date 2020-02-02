using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState
{
    public static HabitatState active_habitat_state{get; set;}
    public static List<CreaturePart> creature_parts{get;}

    static GameState()
    {
        Debug.Log("Loading State...");

        GameState.active_habitat_state = null;
        GameState.creature_parts = GameUtils.load_creature_parts(
            "creature_parts.json"
        );
        
        Debug.Log("Loaded State.");
    }
}

public class HabitatState
{
    public Habitat habitat {get;}
    public Creature creature {get;}

    public bool isRunning {get;set;}

    public HabitatState(Habitat hab)
    {
        this.habitat = hab;
        this.creature = new Creature();
    }

    public CreatureOutcome creature_outcome()
    {
        return this.habitat.creature_outcome(this.creature);
    }
}

public static class HABITAT_STATES
{
    public static HabitatState GRASSLANDS = new HabitatState(new GrasslandsHabitat());
    public static HabitatState TUNDRA = new HabitatState(new TundraHabitat());
    public static HabitatState SHORE = new HabitatState(new ShoreHabitat());
    public static HabitatState DESERT = new HabitatState(new DesertHabitat());
    
    public static List<HabitatState> ALL = new List<HabitatState>{
        HABITAT_STATES.GRASSLANDS,
        HABITAT_STATES.TUNDRA,
        HABITAT_STATES.SHORE,
        HABITAT_STATES.DESERT
    };
}
