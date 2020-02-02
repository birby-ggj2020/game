using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BiomeSelector : MonoBehaviour
{
    public Image grasslands_state_badge;
    public Image tundra_state_badge;
    public Image shore_state_badge;
    public Image desert_state_badge;

    public void Start()
    {
        this._update_state_badge(
            grasslands_state_badge,
            HABITAT_STATES.GRASSLANDS
        );
        this._update_state_badge(
            grasslands_state_badge,
            HABITAT_STATES.GRASSLANDS
        );
        this._update_state_badge(
            grasslands_state_badge,
            HABITAT_STATES.GRASSLANDS
        );
        this._update_state_badge(
            grasslands_state_badge,
            HABITAT_STATES.GRASSLANDS
        );
    }

    private void _update_state_badge(Image badge,
                                     HabitatState state)
    {
        badge.sprite = GameUtils.load_sprite(this._state_sprite_path(state));
    }

    private string _state_sprite_path(HabitatState state)
    {
        if (state.creature_outcome().is_good)
        {
            return "Assets/Graphics/Birby-2.png";
        }
        return "Assets/Graphics/Birby-1.png";
    }

    public void OpenGrasslandsBiome()
    {
        Debug.Log("Biome Selector > Creature Editor: Grasslands");

        GameState.active_habitat_state = HABITAT_STATES.GRASSLANDS;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void OpenTundraBiome()
    {
        Debug.Log("Biome Selector > Creature Editor: Tundra");

        GameState.active_habitat_state = HABITAT_STATES.TUNDRA;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void OpenShoreBiome()
    {
        Debug.Log("Biome Selector > Creature Editor: Shore");

        GameState.active_habitat_state = HABITAT_STATES.SHORE;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void OpenDesertBiome()
    {
        Debug.Log("Biome Selector > Creature Editor: Desert");

        GameState.active_habitat_state = HABITAT_STATES.DESERT;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void Exit()
    {
        Debug.Log("Biome Selector > Exit");

        Application.Quit();
    }
}
