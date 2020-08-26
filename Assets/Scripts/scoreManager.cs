using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public int score;
    public Text scoredisplay;

    private void Update()
    {
        scoredisplay.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle"))
        {
            score++;
        }
    }
}
