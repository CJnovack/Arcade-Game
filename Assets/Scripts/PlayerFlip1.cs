using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip1 : MonoBehaviour
{
    public bool isPlayerOne = true;
    private float horizontalInput;
    private bool faceingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (isPlayerOne)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        else
        {
            horizontalInput = Input.GetAxisRaw("Horizontal2");
        }

        SetupDirectionByScale();
    }
    private void SetupDirectionByScale()
    {
        if ((horizontalInput < 0 && faceingRight) || (horizontalInput > 0 && !faceingRight))
        {
            faceingRight = !faceingRight;
            Vector3 playerScale = transform.localScale;
            playerScale.x *= -1;
            transform.localScale = playerScale;
        }
    }
}
