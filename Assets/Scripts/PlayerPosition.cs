using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private void Update() {
        GameStats.instance.playerPosition = transform.position;
    }
}
