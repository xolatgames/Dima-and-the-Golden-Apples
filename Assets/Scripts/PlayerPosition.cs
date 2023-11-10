using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPosition : MonoBehaviour
{
    private void Start() {
        if (GameStats.instance.levelPositions.ContainsKey(SceneManager.GetActiveScene().name))
        {
            transform.position = GameStats.instance.levelPositions[SceneManager.GetActiveScene().name];
        }
    }

    private void Update() {
        GameStats.instance.playerPosition = transform.position;
    }
}
