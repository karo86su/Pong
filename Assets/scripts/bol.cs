using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pong : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(Xposition, Yposition, 0);
        xSpeed = 1f;
        ySpeed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime; 
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1;
        }
                if (colision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1;
        }
    }   
}
