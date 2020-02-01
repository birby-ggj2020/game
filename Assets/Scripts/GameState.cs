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
}

public static class GameState
{
    public static List<HabitatState> habitats;

    static GameState()
    {
        GameState.habitats = new List<HabitatState>{
            new HabitatState(new GrasslandHabitat()),
            new HabitatState(new TundraHabitat())
        };
    }
}
