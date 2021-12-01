using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirRaton : MonoBehaviour
{
    [SerializeField] private camara camaras;
    [SerializeField] private Transform save;
    bool guardado = false;
    void Awake()
    {
        camaras = FindObjectOfType<camara>();
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (guardado == false)
            {
                guardado = true;
                save = camaras.GetCamara();
            }
            Vector3 posiciondelmouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posiciondelmouse.z = 0;
            transform.position = posiciondelmouse;
            camaras.setCamara(transform);
        }
        if (Input.GetMouseButtonUp(1))
        {
            camaras.setCamara(save);
            guardado = false;
        }
    }
}
