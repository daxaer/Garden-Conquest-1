using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectile : MonoBehaviour
{
    Rigidbody2D rb2D;
    public GameObject proyectile;
    bool cambiarColor = true;
    bool distancia = true;
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
    public void MouseIn()
    {
        //cambiarColor = true;
        //if (cambiarColor && distancia)
        //{
        Debug.Log("Entre");
            GetComponent<SpriteRenderer>().material.color = Color.red;
        //}
    }
    public void MouseExit()
    {
        //cambiarColor = false;
        //if (cambiarColor == false)
        //{
            GetComponent<SpriteRenderer>().material.color = Color.white;
        //}
    }
    public void MouseClick()
    {
        if (cambiarColor /*&& distancia*/)
        {
            Destroy(gameObject);
        }
    }
}
