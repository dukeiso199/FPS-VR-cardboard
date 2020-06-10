using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public float time = 0;
    public float Spawntime = 3;
    public Transform leftside, rightside, topside, botside, frontside, backside;
    public GameObject spawnpoint;
    public GameObject Enemy1prefab;
    public GameObject Enemy2prefab;
    // next version
    //public GameObject light;
    //public bool isday = true;
    //public float cyclechange = 10;
    //public float cycletime = 0;
    private void Update()
    {
        Spawnenemy();
    }
    public void Spawnenemy ()
    {
        time += 1 * Time.deltaTime;
        //cycletime += 1 * Time.deltaTime;
        if(time >= Spawntime)
        {
            RandomPoistion();
            //if (isday)
            //{
               GameObject fox = Instantiate(Enemy1prefab, spawnpoint.transform.position, Quaternion.identity);
                time = 0;
                fox.transform.LookAt(player.transform);
            //}else if (!isday)
            //{
                //GameObject fox = Instantiate(Enemy2prefab, spawnpoint.transform.position, Quaternion.identity);
                //time = 0;
                //fox.transform.LookAt(player.transform);

            //}

        }
        //if (cycletime>= cyclechange)
        //{
        //    if (isday)
        //    {
        //        isday = false;
        //        light.SetActive(false);
        //        cycletime = 0; 
        //    }if (!isday)
        //    {
        //        isday = true;
        //        light.SetActive(true);
        //        cycletime = 0; 
        //    }
        //}

    }
    public void RandomPoistion()
    {
        float randomx, randomy, randomz;
        randomx = Random.Range(leftside.position.x, rightside.position.x);
        randomy = Random.Range(botside.position.y, topside.position.y);
        randomz = Random.Range(backside.position.z, frontside.position.z);
        spawnpoint.transform.position = new Vector3(randomx, randomy, randomz);
    }
}
