using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAim : MonoBehaviour
{
    InputController inputActions;
    [SerializeField] private int minimo = 0;
    [SerializeField] private int maximo = 0;
    [SerializeField] private int miTurno;
    int poderActual;
    int anguloActual;
    [SerializeField] GameObject flecha;
    public Disparar disparar;
    [SerializeField] private Image barradevida;
    [SerializeField] private float vida = 20;
    [SerializeField] private float vidaActual = 20;
    [SerializeField] private string victoria = "";
    [SerializeField] private Text ganaste;

    private void Update()
    {
        if(Input.GetMouseButton(0) && GameManager.Instance.GetTurn() == miTurno && GameManager.Instance.GetDisparando() == false && GameManager.Instance.GetMunicionCargada() == true)
        {
            GameManager.Instance.SetApuntando(true);
            flecha.GetComponent<SpriteRenderer>().enabled = true;
            CalcularAngulo();
            CalcularPoder();
        }
        else if(Input.GetMouseButtonUp(0) && GameManager.Instance.GetTurn() == miTurno && GameManager.Instance.GetDisparando() == false && GameManager.Instance.GetMunicionCargada() == true)
        {
            GameManager.Instance.SetApuntando(false);
            GameManager.Instance.SetDisparando(true);
            disparar.DispararProyectile(poderActual);
            flecha.GetComponent<SpriteRenderer>().enabled = false;
            GameManager.Instance.SetMunicionCargada(false);
        }
    }

    private void Apuntar()
    {
        CalcularPoder();
        CalcularAngulo();
    }

    private void CalcularAngulo()
    {
        Vector3 posicionDelMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionDelMouse.z = 0;

        Vector3 direccion = posicionDelMouse - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;

        ActualizarAngulo((int)angulo);
    }

    private void ActualizarAngulo(int angulo)
    {
        anguloActual = angulo;
        flecha.transform.rotation = Quaternion.AngleAxis(anguloActual, Vector3.forward);
    }

    private void CalcularPoder()
    {
        Vector3 posicionDelMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        posicionDelMouse.z = 0;

        float distancia = Vector3.Distance(posicionDelMouse, transform.position);
        ActualizarPoder((int)distancia * 2);
    }

    private void ActualizarPoder(int distancia)
    {
        poderActual = Mathf.Clamp(distancia, minimo, maximo);
        flecha.transform.localScale = new Vector2(poderActual/10 , 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("proyectile"))
        {
            vidaActual =  vidaActual - 5;
            barradevida.fillAmount = vidaActual / vida;

            if (vidaActual <= 0)
            {
                ganaste.text = victoria;
                gameObject.SetActive(false);
            }
        }

    }
}
