using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] GameObject follow;
    public CinemachineVirtualCamera cam;
    private void Start()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
        cam.Follow = follow.transform;
    }

    public void setCamara(Transform objetivos)
    {
        cam.Follow = objetivos.transform;
    }
    public Transform GetCamara()
    {
        return cam.Follow;
    }
}