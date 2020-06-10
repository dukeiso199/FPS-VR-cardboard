using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public GameObject seekerBullet;
    public GameObject mainCamera;

    private bool WantSeekerBullet;

    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private int _score;

    //two variables will used to control fire rate
    [SerializeField]
    private float _fireRate = 1.8f;
    private float _canFire = -1f;
    // Start is called before the first frame update
    void Start()
    {
        WantSeekerBullet = true;
        _scoreText.text = "Score: " + 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (WantSeekerBullet == true)
        {
            if (Input.GetMouseButtonDown(0) && Time.time > _canFire)
            {
                _canFire = Time.time + _fireRate;
                Instantiate(seekerBullet, mainCamera.transform.position, mainCamera.transform.rotation);
            }
                
        }
            
        
            
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
               
                Instantiate(bullet, mainCamera.transform.position, mainCamera.transform.rotation);
            }
        }
            
    }

    

    public void chooseNormalBullet()
    {
        WantSeekerBullet = false;
    }
    public void chooseSeekerBullet()
    {
        WantSeekerBullet = true;
    }

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Score: " + playerScore.ToString();
    }

    public void AddScore()
    {
        _score += 1;
        UpdateScore(_score);
    }
}
