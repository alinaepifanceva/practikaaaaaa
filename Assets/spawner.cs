using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] GearVariants;

    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime=0.65f;
    public float minTime;
    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand=Random.Range(0, GearVariants.Length);

            Instantiate(GearVariants[rand], transform.position,Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(timeBtwSpawn > minTime) 
            {
            startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
