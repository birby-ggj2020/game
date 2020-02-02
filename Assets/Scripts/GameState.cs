using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEditor;

public static class GameState
{
    public static HabitatState GRASSLANDS{get;}
    public static HabitatState TUNDRA{get;}
    public static HabitatState SHORE{get;}
    public static HabitatState DESERT{get;}

    public static List<HabitatState> all_habitats{get;}
    public static HabitatState active_habitat_state{get; set;}
    public static List<CreaturePart> creature_parts{get;}
    // public static Dictionary<CreaturePartType, List<CreaturePart> > creature_parts_by_type;

    static GameState()
    {
        Debug.Log("Loading State...");

        GameState.GRASSLANDS = new HabitatState(new GrasslandsHabitat());
        GameState.TUNDRA = new HabitatState(new TundraHabitat());
        GameState.SHORE = new HabitatState(new ShoreHabitat());
        GameState.DESERT = new HabitatState(new DesertHabitat());

        GameState.all_habitats = new List<HabitatState>{
            GameState.GRASSLANDS,
            GameState.TUNDRA,
            GameState.SHORE,
            GameState.DESERT
        };
        GameState.active_habitat_state = null;

        GameState.creature_parts = GameUtils.load_creature_parts(
            "creature_parts.json"
        );
        
        Debug.Log("Loaded State.");
    }
}

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

public static class GameUtils
{
    [System.Serializable]
    public class _RawPartList
    {
        public List<_RawPart> parts;
    }

    [System.Serializable]
    public class _RawPart
    {
        public string name;
        public string type;
        public string sprite_path;
    }

    private static Dictionary<string, CreaturePartType> _PART_TYPE_LOOKUP
        = new Dictionary<string, CreaturePartType>{
            ["head"] = CreaturePartType.HEAD,
            ["legs"] = CreaturePartType.LEGS,
            ["back"] = CreaturePartType.BACK,
            ["tail"] = CreaturePartType.TAIL,
            ["skin"] = CreaturePartType.SKIN
        };

    public static List<CreaturePart> load_creature_parts(string json_asset_path)
    {
        string filepath = Application.dataPath + "/" + json_asset_path;
        string json_str = File.ReadAllText(filepath);

        _RawPartList raw_parts = JsonUtility.FromJson<_RawPartList>(json_str);

        List<CreaturePart> loaded_parts = new List<CreaturePart>();
        foreach (_RawPart raw in raw_parts.parts)
        {
            loaded_parts.Add(GameUtils._parse_part(raw));
        }
        return loaded_parts;
    }

    private static CreaturePart _parse_part(_RawPart raw)
    {
        return new CreaturePart(
            raw.name,
            GameUtils._parse_part_type(raw.type),
            GameUtils.parse_sprite_path(raw.sprite_path)
        );
    }

    private static CreaturePartType _parse_part_type(string name)
    {
        return GameUtils._PART_TYPE_LOOKUP[name];
    }

    public static Sprite parse_sprite_path(string sprite_path)
    {
        var texture = AssetDatabase.LoadAssetAtPath(
            sprite_path,
            typeof(Texture2D)
        ) as Texture2D;
        var sprite = Sprite.Create(
            texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0f, 0f), 1.0f
        );
        return sprite;       
    }
}
