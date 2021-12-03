using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void CambiarScena(int scena)
    {
        if(scena == 1)
        {
            SceneManager.LoadScene(2);
        }
        if (scena == 2)
        {
            SceneManager.LoadScene(3);
        }
        if (scena == 3)
        {
            Application.Quit();
        }
    }
}
