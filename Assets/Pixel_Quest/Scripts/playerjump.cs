using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class playerjump : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;

    public float jumpForce = 10;
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;

    
    // Start is called before the first frame update
    void Start() { 
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
          new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck || _waterCheck)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }

        if(_rigidbody2D.velocity.y < 0 && !_waterCheck)
    {
            //_rigidbody2D.velocity += _gravityVector * (fallForce * Time.deltaTime);
        }
    }
    
    private bool _waterCheck = false;
    private string _waterTag = "water";
   

    private void OnTriggerEnter2D(Collider2D collision)

    { if (collision.CompareTag(_waterTag)) { _waterCheck = true; } }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag)) { _waterCheck = false; }
    }
} 

