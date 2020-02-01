using UnityEngine;

public enum CreaturePartType
{
    HEAD,
    LIMBS,
    //BODY,
    ACCESSORY,
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

        if(this.sprite != null){
            Debug.Log("Loaded sprite");

        }
    }
}