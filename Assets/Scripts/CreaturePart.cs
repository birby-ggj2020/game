﻿using UnityEngine;

public enum CreaturePartType
{
    HEAD,
    LEGS,
    BACK,
    TAIL,
    SKIN
}

public class CreaturePart
{
    public string name;
    public CreaturePartType type;
    public Sprite sprite;

    public CreaturePart(string name,
                        CreaturePartType type,
                        Sprite sprite)
    {
        this.name = name;
        this.type = type;
        this.sprite = sprite;
    }
}

public static class CREATURE_PARTS
{
    
}