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
        return creature.head.name == "brontosaurus"
            || creature.back.name == "batwings"
            || creature.back.name == "birdwings";
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
        return creature.legs.name == "furry"
            && creature.back.name == "furry";
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

    public bool creature_is_correct(Creature creature)
    {
        return false;
        // return creature.legs.name == "furry"
        //     && creature.back.name == "furry";
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

    public bool creature_is_correct(Creature creature)
    {
        return false;
        // return creature.legs.name == "furry"
        //     && creature.back.name == "furry";
    }
}