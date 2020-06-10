using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
   

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject, 2);
        }
    }
}
