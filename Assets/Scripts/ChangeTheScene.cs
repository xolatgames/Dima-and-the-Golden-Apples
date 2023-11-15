using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTheScene : MonoBehaviour
{
    public void ChangeToTheScene(string scene)
    {
        GameStats.instance.levelPositions[SceneManager.GetActiveScene().name] = GameStats.instance.playerPosition;
        SceneManager.LoadScene(scene);
    }
}
