using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    public float speed = 0;
    public float maxspeed = 50;
    private bool isTurnOn = false;

    private bool isCeiling()
    {
        return speed>0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (speed>maxspeed)
        {
            speed = maxspeed;
        }
        if (speed<0)
        {
            speed=0;
        }

        if (isTurnOn)
        {
            speed += Time.deltaTime * 4;
        }
        else if (!isTurnOn && isCeiling())
        {
            speed -= Time.deltaTime * 4;
        }

        this.transform.Rotate(0f,0f,speed);
    }

    public void TurnOnOff()
    {
        if (!isTurnOn)
        {
            this.GetComponent<AudioSource>().Play();
        }
        else
        {
            this.GetComponent<AudioSource>().Stop();
        }
        isTurnOn = !isTurnOn;
    }
}
