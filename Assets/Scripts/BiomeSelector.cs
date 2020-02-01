using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BiomeSelector : MonoBehaviour
{
    public void OpenGrasslandsBiome()
    {
        GameState.active_habitat_index = 0;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void OpenTundraBiome()
    {
        GameState.active_habitat_index = 1;
        SceneManager.LoadScene("CreatureEditor");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
