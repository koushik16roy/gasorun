using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Vector2 targetPos;
    public float yIncrement;
    public float speed;    //player up and down speed
    //player bounds in frame
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public GameObject playerEffect;
    public GameObject gameOver;
    public Text healthd;
    
    public void Update()
    {
        healthd.text = health.ToString();
        if(health <=0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.W)  && transform.position.y < maxHeight)
        {
            Instantiate(playerEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
        }
        else if(Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            Instantiate(playerEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
        }
    }
}
