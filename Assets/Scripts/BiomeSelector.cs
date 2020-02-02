using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BiomeSelector : MonoBehaviour
{
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
