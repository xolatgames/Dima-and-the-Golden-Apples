using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]
    private GameObject sword;
    [SerializeField]
    private Animator swordAnim;
    [SerializeField]
    private float swordDistance = 2.0f;
    [SerializeField]
    private float damage = 1.0f;

    private void Update() {
        ShowOrDontShow();

        if (sword.activeSelf)
        {
            Attack();
        }
    }

    private void ShowOrDontShow()
    {
        if (GameStats.instance.sword)
        {
            sword.SetActive(true);
        }
        else
        {
            sword.SetActive(false);
        }
    }

    private void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), -transform.forward * swordDistance, out hit))
            {
                if (hit.collider.GetComponent<Enemy>())
                {
                    hit.collider.GetComponent<Enemy>().TakeTheDamage(damage);
                }
            }

            swordAnim.Play("Attack");
        }
    }
}
