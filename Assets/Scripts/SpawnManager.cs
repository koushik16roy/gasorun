using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacle;
    private float timebtwspawn;
    public float starttimespwan;
    public float timedecrease;
    public float minTime;

    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
       if(timebtwspawn <= 0)
        {
            int random = Random.Range(1, obstacle.Length);
            Instantiate(obstacle[random], transform.position, Quaternion.identity);
            timebtwspawn = starttimespwan;
            if(starttimespwan > minTime)
            {
                starttimespwan -= timedecrease;
            }
        }
       else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }
}
