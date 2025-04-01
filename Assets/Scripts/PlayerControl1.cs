using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl1 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5.0f;
    public float xRange = 8;
    public float yRange = 9;
    public string horizontalAxis;
    public string verticalAxis;
    public bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        horizontalInput = Input.GetAxis(horizontalAxis);
        verticalInput = Input.GetAxis(verticalAxis);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       // transform.Translate(Vector3.left * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        //transform.Translate(Vector3.down * verticalInput * Time.deltaTime * speed);
        //transform.Translate(1, 0, 0);
    }
    public void GameEnd()
    {
        //PlayerControl1.gameObject.GetComponent<PlayerControl1>().enabled = false;
        isGameActive = false;
    }

}
