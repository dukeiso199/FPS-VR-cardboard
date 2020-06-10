using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekerBullet : MonoBehaviour
{
    Rigidbody rb;
    public float force = 20;
    GameObject[] Enemies;
    private GameObject closestEnemy = null;

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

        Enemies = GameObject.FindGameObjectsWithTag("enemy");

        if (Enemies.Length == 0)
        {
            Debug.Log("There is no any enemy");
        }
        else
        {
            closestEnemy = FindClosestEnemy();
            print(closestEnemy.name);
            transform.LookAt(closestEnemy.transform);
            Vector3 afterForce = gameObject.transform.forward * force;

            rb.AddForce(afterForce, ForceMode.VelocityChange);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "enemy")
        {
            Debug.Log("collided");
            _shooterScript.AddScore();
            Destroy(collision.gameObject);
        }

        Destroy(this.gameObject);
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

}
