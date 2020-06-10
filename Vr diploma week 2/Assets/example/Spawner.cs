using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float counter = 0;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
       // Destroy(gameObject, 4f);

    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        //counter = counter + Time.deltaTime;
        if (counter > 2)
        {

            Vector3 newPost = transform.position + new Vector3(Random.Range(-2f, 3f), 0, Random.Range(-3f, 3f));
            Instantiate(enemy, newPost, transform.rotation);
            counter = 0;

        }
    }
}
