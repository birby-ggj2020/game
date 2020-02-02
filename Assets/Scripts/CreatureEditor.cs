using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class CreatureEditor : MonoBehaviour
{

    public AudioClip Grasslands;
    public AudioClip Tundra;

    public AudioClip Shore;
    public AudioClip Desert;
    void Start()
    {
        if (GameState.active_habitat_state == null)
        {
            Debug.Log("Started Creature Editor with no active habitat; defaulting to Grasslands");
            GameState.active_habitat_state = GameState.GRASSLANDS;
        }
        Habitat habitat = GameState.active_habitat_state.habitat;
        Debug.Log("Starting Creature Editor: " + habitat.name);

        var image = this.GetComponentInChildren<Image>();
        image.sprite = GameUtils.parse_sprite_path(habitat.background_img_path);

        var audio =  Camera.main.GetComponent<AudioSource>();
        switch(habitat.name){
            case "Grasslands":
                audio.clip = Grasslands;
                break;
            case "Tundra":
                audio.clip = Tundra;
                break;
            case "Shore":
                audio.clip = Shore;
                break;
            case "Desert":
                audio.clip = Desert;
                break;            
            default:
                break;
        }
        audio.loop = true;
        audio.Play();
    }

    public void Back()
    {
        Debug.Log("Creature Editor > Biome Selector");

        SceneManager.LoadScene("BiomeSelector");
    }
}
