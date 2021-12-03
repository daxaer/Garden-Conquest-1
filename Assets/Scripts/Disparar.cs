using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject[] prefabProyectile;
    public Transform spawn;
    public int proyectile;
    [SerializeField] private camara camaras;
    Transform save;

    public void DispararProyectile(int poder)
    {
        GameObject instanciarProyectile = Instantiate(prefabProyectile[proyectile], spawn.transform.position, spawn.transform.rotation);
        instanciarProyectile.GetComponent<Proyectile>().Iniciar(poder);
        instanciarProyectile.layer = gameObject.layer;
        camaras.setCamara(instanciarProyectile.transform);
        StartCoroutine("CambiarCamara");
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            proyectile = 0;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            proyectile = 1;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            proyectile = 2;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            proyectile = 3;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            proyectile = 4;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            proyectile = 5;
            GameManager.Instance.SetMunicionCargada(true);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            proyectile = 6;
            GameManager.Instance.SetMunicionCargada(true);
        }
    }
    IEnumerator CambiarCamara()
    {
        yield return new WaitForSeconds(8f);
        camaras.setCamara(transform);
    }
}
