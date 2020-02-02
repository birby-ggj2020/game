using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class CreatureEditor : MonoBehaviour
{
    void Start()
    {
        HabitatState habitat_state = GameState.active_habitat_state;
        if (habitat_state == null)
        {
            Debug.LogError("Started Creature Editor with no active habitat");
            return;
        }
        Habitat habitat = habitat_state.habitat;
        Debug.Log("Starting Creature Editor: " + habitat.name);

        var image = this.GetComponentInChildren<Image>();
        image.sprite = GameUtils.parse_sprite_path(habitat.background_img_path);
    }

    public void Back()
    {
        Debug.Log("Creature Editor > Biome Selector");

        SceneManager.LoadScene("BiomeSelector");
    }
}
