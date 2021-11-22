using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject[] prefabProyectile;
    public Transform spawn;
    public void DispararProyectile(int poder)
    {
        GameObject instanciarProyectile = Instantiate(prefabProyectile[GameManager.Instance.GetProyectile()], spawn.transform.position, spawn.transform.rotation);
        instanciarProyectile.GetComponent<Proyectile>().Iniciar(poder);
    }
}
