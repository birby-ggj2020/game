using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

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

        GameState.creature_parts = _CreaturePartLoader.load_creature_parts(
            "creature_parts.json"
        );
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

public static class _CreaturePartLoader
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
            ["limbs"] = CreaturePartType.LIMBS,
            // ["body"] = CreaturePartType.BODY,
            ["accessory"] = CreaturePartType.ACCESSORY,
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
            loaded_parts.Add(_CreaturePartLoader._parse_part(raw));
        }
        return loaded_parts;
    }

    private static CreaturePart _parse_part(_RawPart raw)
    {
        return new CreaturePart(
            raw.name,
            _CreaturePartLoader._parse_part_type(raw.type),
            _CreaturePartLoader._parse_sprite_path(raw.sprite_path)
        );
    }

    private static CreaturePartType _parse_part_type(string name)
    {
        return _CreaturePartLoader._PART_TYPE_LOOKUP[name];
    }

    private static Sprite _parse_sprite_path(string sprite_path)
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