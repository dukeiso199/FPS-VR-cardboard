using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotataion : MonoBehaviour
{
    public int rotatedegree = 4;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Camera.main.transform.Rotate(0, rotatedegree, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Camera.main.transform.Rotate(-rotatedegree,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Camera.main.transform.Rotate(0, -rotatedegree, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Camera.main.transform.Rotate(rotatedegree,0,0);
        }
        
    }
}
