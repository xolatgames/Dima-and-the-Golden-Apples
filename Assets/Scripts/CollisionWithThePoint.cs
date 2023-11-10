using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayerMovement))]
public class CollisionWithThePoint : MonoBehaviour
{
    private bool active = false;

    private void Start() {
        StartCoroutine(Activate());
    }

    IEnumerator Activate()
    {
        yield return new WaitForSeconds(1);

        active = true;
    }

    private void OnTriggerEnter(Collider other) {
        if (active)
        {
            if (other.gameObject.tag == "Point")
            {
                other.GetComponent<Point>().callTheEvent();
            }
        }
    }
}
