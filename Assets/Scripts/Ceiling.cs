using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    public float speed = 4;


    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(0f,0f,speed);
    }
}
