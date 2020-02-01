using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: pull name/background_img_path out to a config; only hardcode actual code.
public interface Habitat
{
    string name {get;}
    string background_img_path {get;}
    bool creature_is_correct(Creature creature);
}

public class GrasslandHabitat : Habitat
{
    public string name
    {
        get => "Grassland";
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