using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector2 jumpForce = new Vector2(0, 300);
    Rigidbody2D myRigi;

    // Use this for initialization
    void Start()
    {

        myRigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            // Jump plane
            myRigi.velocity = Vector2.zero;
            myRigi.AddForce(jumpForce);
        }
        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}



