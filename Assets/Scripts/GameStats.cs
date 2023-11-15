using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    public static GameStats instance = null;
    public float health = 10;
    public float maxHealth = 10;
    public Vector3 playerPosition;
    public Dictionary<string, Vector3> levelPositions = new Dictionary<string, Vector3>();
    public string task = "";
    public bool sword = true;
    public Dictionary<string, bool> playedAnimation = new Dictionary<string, bool>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
}
