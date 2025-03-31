using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    private Rigidbody body;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);
        spriteRenderer.flipX = body.velocity.x < 0f;
    }
 }
