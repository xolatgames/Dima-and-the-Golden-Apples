using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTheScene : MonoBehaviour
{
    public void ChangeToTheScene(string scene)
    {
        if (!GameStats.instance.levelPositions.ContainsKey(SceneManager.GetActiveScene().name))
        {
            GameStats.instance.levelPositions.Add(SceneManager.GetActiveScene().name, GameStats.instance.playerPosition);
        }
        SceneManager.LoadScene(scene);
    }
}
