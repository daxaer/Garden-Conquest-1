using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirRaton : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            Vector3 posiciondelmouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posiciondelmouse.z = 0;
            transform.position = posiciondelmouse;
        }
    }
}
