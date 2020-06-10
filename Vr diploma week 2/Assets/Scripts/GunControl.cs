using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunControl : MonoBehaviour
{
    public GameObject normalbullet;
    public GameObject homingbullet;
    public int bullettype = 0;
    public Text bullettypetext;
    // try
    public float magnitude = 200;
    public GameObject[] enemies;
    public float force = 100;

    public LayerMask layermask;
    public Text canvastext;
    public GameObject outershell;
    public SHadeReavel sr;
    public Text scoretext;
    public int score = 0;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, layermask))
        {
            Debug.DrawRay(transform.position, Camera.main.transform.forward * 1000, Color.yellow);

            if (hit.transform.tag == "Enemy")
            {

                canvastext.gameObject.SetActive(true);
                sr = hit.transform.gameObject.GetComponent<SHadeReavel>();

                if (sr)
                {
                    sr.show();



                }
                else
                {
                    if (sr)
                        sr.hide();
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (bullettype == 0)
                {
                    Instantiate(normalbullet, transform.position, Camera.main.transform.rotation);
                }
                else if (bullettype == 1)
                {
                    GameObject bullet = Instantiate(homingbullet, transform.position, transform.rotation);



                }
            }
            if (Input.GetMouseButtonDown(1))
            {
                if (bullettype == 0)
                {
                    bullettype = 1;


                }
                else if (bullettype == 1)
                {
                    bullettype = 0;


                }
            }
        }
    }
}


