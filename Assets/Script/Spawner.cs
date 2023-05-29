using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float maxTimer;
    float timer;
    public float maxY;
    public float minY;
    float randomY;


    void Start()
    {
        InstantiateObsticle();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameOver==false)
        {
            timer += Time.deltaTime;
            if (timer >= maxTimer)
            {
                randomY = Random.Range(minY, maxY);
                InstantiateObsticle();
                timer = 0;
            }

        }
       
    }

    public void InstantiateObsticle()
    {
        GameObject newObstacle= Instantiate(obstacle);
        newObstacle.transform.position=new Vector2(transform.position.x, randomY);
    }
}
