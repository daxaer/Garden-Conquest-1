using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int idProyectile = 1;
    [SerializeField] private int Turno = 1;
    [SerializeField] private bool disparando = false;
    [SerializeField] private bool puedoDisparar = true;
    [SerializeField] private bool apuntando = false;
    [SerializeField] private bool munisionCargada = false;
    [SerializeField] private Text tiempo;
    public camara cam;
    public Player[] jugadores;
    int time = 10;
    public static GameManager Instance;
    Transform objetivo;

    void Awake()
    {
        puedoDisparar = true;
        if (Instance == null) 
        {
            DontDestroyOnLoad(gameObject); 
            Instance = this;
        }
        else if (Instance != this) 
        {
            Destroy(gameObject); 
        }
        StartCoroutine("CambiarTurno");

    }
    public void SetProyectile(int id)
    {
        idProyectile = id;
    }
    public void SetDisparando(bool disparo)
    {
        disparando = disparo;
    }
    public void SetApuntando(bool apuntar)
    {
        apuntando = apuntar;
    }
    public void SetPuedoDisparar(bool disparar)
    {
        puedoDisparar = disparar;
    }
    public void SetMunicionCargada(bool muncion)
    {
        munisionCargada = muncion;
    }
    public void SetObjetivos(Transform objetivos)
    {
       objetivo = objetivos;
    }
    public Transform GetObjetivos()
    {
        return objetivo;
    }

    public int GetProyectile()
    {
        return idProyectile;
    }
    public int GetTurn()
    {
        return Turno;
    }
    public bool GetDisparando()
    {
        return disparando;
    }
    public bool GetApuntando()
    {
        return apuntando;
    }
    public bool GetPuedoDisparar()
    {
        return puedoDisparar;
    }
    public bool GetMunicionCargada()
    {
        return munisionCargada;
    }
    IEnumerator CambiarTurno()
    {
        yield return new WaitForSeconds(1f);
        if(time < 1)
        {
            time = 10;
            puedoDisparar = true;
            if (Turno == 1)
            {
                objetivo = jugadores[1].SetObjetivos();
                cam.setCamara(objetivo);
                Turno = 2;
            }
            else
            {
                objetivo = jugadores[0].SetObjetivos();
                cam.setCamara(objetivo);
                Turno = 1;
            }
            disparando = false;
            tiempo.text = time.ToString();
            StartCoroutine("CambiarTurno");
        }
        else
        {
            time--;
            tiempo.text = time.ToString();
            StartCoroutine("CambiarTurno");
        }
        
    }
}
