using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerPosition))]
[RequireComponent (typeof (CharacterController))]
[RequireComponent (typeof (CollisionWithThePoint))]
public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    private bool canMove = false;
    private float mouseSensitive = 4.0f;
    private float playerSpeed = 0.02f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update() {
        if (canMove)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSensitive, 0);

            controller.Move((Input.GetAxis("Horizontal") * -transform.right * playerSpeed) + 
(Input.GetAxis("Vertical") * -transform.forward * playerSpeed));
        }
    }
}
