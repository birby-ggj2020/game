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
            var path = GameState.active_habitat_state().habitat.background_img_path;
            image.sprite = GameUtils.parse_sprite_path(path);
        }
    }
}
