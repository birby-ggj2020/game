using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO: pull name/background_img out to a config; only hardcode actual code.
public interface Habitat
{
    string name {get;}
    Image background_img {get;}
    bool creature_is_correct(Creature creature);
}

public class GrasslandsHabitat : Habitat
{
    public string name
    {
        get => "Grasslands";
    }

    public Image background_img
    {
        get => Resources.Load("Assets/Graphics/grasslands.png") as Image;
    }

    public bool creature_is_correct(Creature creature)
    {
        return creature.head.name == "LongNeck"
            && creature.limbs.name == "LongLegs";
    }
}

public class TundraHabitat : Habitat
{
    public string name
    {
        get => "Tundra";
    }

    public Image background_img
    {
        get => Resources.Load("Assets/Graphics/snow.png") as Image;
    }

    public bool creature_is_correct(Creature creature)
    {
        return creature.skin.name == "Hair";
    }
}