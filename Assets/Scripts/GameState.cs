using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class HabitatState
{
    public Habitat habitat {get;}
    public Creature creature {get;}

    public HabitatState(Habitat hab)
    {
        this.habitat = hab;
        this.creature = new Creature();
    }

    public bool creature_is_correct()
    {
        return this.habitat.creature_is_correct(this.creature);
    }
}

public static class GameState
{
    public static List<HabitatState> habitats;
    public static int? active_habitat_index;
    public static List<CreaturePart> creature_parts;
    // public static Dictionary<CreaturePartType, List<CreaturePart> > creature_parts_by_type;

    static GameState()
    {
        GameState.habitats = new List<HabitatState>{
            new HabitatState(new GrasslandsHabitat()),
            new HabitatState(new TundraHabitat())
        };
        GameState.active_habitat_index = null;
        GameState.creature_parts = new List<CreaturePart>{
            new CreaturePart(
                "LongNeck",
                CreaturePartType.HEAD,
                LoadImage("Assets/Graphics/creature_parts/Exquisite_Small-24.png")
                
            )
        };
    }

    private static Sprite LoadImage(string path){
        var texture = AssetDatabase.LoadAssetAtPath(path, typeof(Texture2D)) as Texture2D;
        var sprite = Sprite.Create(texture, new Rect(0,0,texture.width,texture.height), new Vector2(0f,0f), 1.0f);
        return sprite;        
    }
}
