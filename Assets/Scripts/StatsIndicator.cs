using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsIndicator : MonoBehaviour
{
    [SerializeField]
    private Slider health;

    private void Update() {
        health.value = GameStats.instance.health;
        health.maxValue = GameStats.instance.maxHealth;
    }
}
