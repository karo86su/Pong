using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class pong : MonoBehaviour
{
    public float Xposition = 0;
    public float Yposition = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + 1 * Time.deltaTime;
        Yposition = Yposition + 0.01f;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }
}
