using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CreaturePartType
{
    HEAD,
    LIMBS,
    // BODY,
    ACCESSORY,
    SKIN
}

[CreateAssetMenu(fileName="a_part", menuName="Birby/New Creature Part")]
public class CreaturePart : ScriptableObject
{
    public string name;
    public CreaturePartType type;
    public string image_path;
}