using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homingbullet : NormalBullet
{
     Rigidbody rb ;
    public GameObject[] enemies;
    public float force = 100;
    private GameObject closestEnemy = null;

    private GameObject _player;
    private GunControl _shooterScript;

    GameObject[] Enemies;
    void Start()
    {
        _player = GameObject.Find("Player");
        Debug.Log(" player found");
        _shooterScript = _player.GetComponent<GunControl>();
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            return;

        Enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (Enemies.Length == 0)
        {
            Debug.Log("There is no any Enemy");
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
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
