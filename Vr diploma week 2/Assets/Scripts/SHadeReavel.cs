using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SHadeReavel : MonoBehaviour
{
    public GameObject outershell;
    public void show()
    {
        outershell.SetActive(true);
    }
    public void hide()
    {
        outershell.SetActive(false);


    }
}
