using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//TODO: pull name/background_img out to a config; only hardcode actual code.
public interface Habitat
{
    string name {get;}
    string background_img_path {get;}
    bool creature_is_correct(Creature creature);
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

    public string background_img_path
    {
        get => "Assets/Graphics/snow.png";
    }

    public bool creature_is_correct(Creature creature)
    {
        return creature.skin.name == "Hair";
    }
}