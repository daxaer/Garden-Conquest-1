using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    public GameObject proyectile;
    Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Invoke("ActivarCollider", 0.5f);
    }
    public void Iniciar(int poder)
    {
        rb2D.AddForce(transform.right * (poder / 2), ForceMode2D.Impulse);
    }

    void ActivarCollider()
    {
        GetComponent<Collider2D>().enabled = true;
        GetComponentInChildren<Collider2D>().enabled = true;
    }
}
