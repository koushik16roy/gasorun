using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerObstacle : MonoBehaviour
{
    public float obstacle;
    private void Start()
    {
        Destroy(gameObject, obstacle);
    }
}
