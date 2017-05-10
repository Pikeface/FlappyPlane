using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Vector2 velocity = new Vector2(-400, 0);
    public float range = 4;
    Rigidbody2D myRigi;

    // Use this for initialization
    void Start()
    {
        myRigi = GetComponent<Rigidbody2D>();
        myRigi.velocity = velocity;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }
}







