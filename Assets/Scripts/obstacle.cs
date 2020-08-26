using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    private int lives = 1;
    public float speed = 5  ;

    public GameObject effect;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<player>().health -= lives;
            Debug.Log(other.GetComponent<player>().health);
            Destroy(gameObject);
        }
    }
}
