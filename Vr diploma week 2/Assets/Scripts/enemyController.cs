using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    //public GameObject player;
    //public float movespeed = 0.001f;
    //Vector3 direction;
    private void Start()
    {
        
        //direction = player.transform.position - this.transform.position;
        
    }
    private void Update()
    {
        //if(Vector3.Distance(player.transform.position,this.transform.position)> 5)
        //{
        //    this.transform.position += direction * movespeed * Time.deltaTime;
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        
    }
}
