using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectileInactivo : MonoBehaviour
{
    bool enRango;

    public void MouseIn()
    {
        if (enRango == true)
        {
            GetComponent<SpriteRenderer>().material.color = Color.red;
        }
    }
    public void MouseExit()
    {
        GetComponent<SpriteRenderer>().material.color = Color.white;
    }
    public void MouseClick()
    {
        Debug.Log(GameManager.Instance.GetPuedoDisparar());
        if (/*enRango &&*/ GameManager.Instance.GetPuedoDisparar() == true)
        {
            GameManager.Instance.SetPuedoDisparar(false);
            GameManager.Instance.SetMunicionCargada(true);
            Destroy(gameObject);
        }
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enRango = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
    if (collision.gameObject.CompareTag("Player"))
        {
            enRango = false;
        }
    }
}
