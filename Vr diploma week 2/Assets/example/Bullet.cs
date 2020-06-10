using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force = 20;

    private GameObject _player;
    private Shooter _shooterScript;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        _shooterScript = _player.GetComponent<Shooter>();
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            return;

        Vector3 afterForce = gameObject.transform.forward * force;

        rb.AddForce(afterForce, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
        //this.transform.position += this.transform.forward * speed;
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.transform.tag == "enemy")
        {
            Debug.Log("collided");
            _shooterScript.AddScore();
            Destroy(collision.gameObject);
        }
        
        Destroy(this.gameObject);
    }
}
