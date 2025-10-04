
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private int variable1 = 3;
    Rigidbody2D rb;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        string variable2 = "world";
        Debug.Log(variable1 + variable2);
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
    }

    // Update is called once per frame
    void Update()
    {
        {
            float xInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        }
       

        if (Input.GetKeyDown(KeyCode.A))
        {
            { rb.velocity = new Vector2(1, rb.velocity.y); }
        }
        if (Input.GetKeyDown(KeyCode.A))
            rb.velocity = new Vector2(-1, rb.velocity.y);

        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
         transform.position += new Vector3(1, 0, 0);
        if (Input.GetKeyDown(KeyCode.A))
        { transform.position += new Vector3(-1, 0, 0); }
        */
    }

}