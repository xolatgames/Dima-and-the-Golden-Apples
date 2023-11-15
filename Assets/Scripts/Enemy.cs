using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (CharacterController))]
public class Enemy : MonoBehaviour
{
    private CharacterController controller;
    public float health = 10;
    [SerializeField]
    private float speed = 1.0f;
    [SerializeField]
    private float gravity = 1.0f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update() 
    {
        transform.LookAt(GameStats.instance.playerPosition);
        transform.Rotate(new Vector3(0, 180, 0));

        controller.Move((-transform.forward * speed + 
new Vector3(0, -gravity, 0)) * Time.deltaTime);
    }

    public void TakeTheDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
