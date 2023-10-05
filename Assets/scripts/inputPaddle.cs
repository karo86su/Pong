using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class paddleGame : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (leftOrRight == "left")
        {
            if (Input.GetKey(up))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(down))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }


//function that handles movement and has variables for up and down keycodes
    void Update()
    {
        if (leftOrRight == "left")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes, W is pressed down.");
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes, S is pressed down.");
            }
        }else if (leftOrRight == "right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                Debug.Log("Yes, up arrow is pressed down.");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                Debug.Log("Yes, down arrow is pressed down.");
            }
        }

    }
}