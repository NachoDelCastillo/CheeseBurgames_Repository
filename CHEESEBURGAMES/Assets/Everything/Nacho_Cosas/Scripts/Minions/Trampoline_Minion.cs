using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline_Minion : MonoBehaviour
{
    [HideInInspector]
    public float trampolineJumpForce = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<OnGround>())
        {
            Vector2 colPos = collision.transform.position;
            if (colPos.y > transform.position.y + 0.1f) // Comprobar si el Minion con el que ha interactuado esta por encima suyo
                if (colPos.x > transform.position.x - transform.localScale.x/2 && colPos.x < transform.position.x + transform.localScale.x / 2) // Comprobar si no esta lejos
                    collision.GetComponentInParent<BasicMovement>().GoUp(trampolineJumpForce); // Aplicar fuerza de salto
        }

    }
}
