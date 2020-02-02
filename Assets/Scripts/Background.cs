using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   if(GameState.active_habitat_index.HasValue){
            var image = this.GetComponent<Image>();
            var path = GameState.habitats[GameState.active_habitat_index.Value].habitat.background_img_path;
            image.sprite = _parse_sprite_path(path);
        }
    }

    public static Sprite _parse_sprite_path(string sprite_path)
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
