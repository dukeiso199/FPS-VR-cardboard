using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2COntroller : MonoBehaviour
{
    //move in circles around player
    //float timeCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timeCounter += Time.deltaTime;
        //float x = Mathf.Cos(timeCounter);
        //float y = Mathf.Sin(timeCounter);
        //float z = 0;
        //transform.position = new Vector3(x, y, z);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }

    }

}
