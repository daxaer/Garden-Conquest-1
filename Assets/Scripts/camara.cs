using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public CinemachineVirtualCamera cam;
    private void Start()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
    }

    public void setCamara(Transform objetivos)
    {
        cam.Follow = objetivos.transform; 
    }
}
