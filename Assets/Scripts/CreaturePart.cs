using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="a_part_type", menuName="Birby/New Creature Part Type")]
public class CreaturePartType : ScriptableObject
{
    public string name;
}

[CreateAssetMenu(fileName="a_part", menuName="Birby/New Creature Part")]
public class CreaturePart : ScriptableObject
{
    public string name;
    public CreaturePartType type;
    public string image_path;
}