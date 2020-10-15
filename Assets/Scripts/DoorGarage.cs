using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGarage : MonoBehaviour
{
    public bool isActive = false;
    public bool isPullUp = false;
    public float speed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isActive);
        if (isActive && this.transform.localScale.z > 0.2 && !isPullUp)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y,
                            this.transform.localScale.z - speed);
            if (this.transform.localScale.z<=0.2)
            {
                isActive = false;
                isPullUp = true;
            }
        }
        if (isActive && this.transform.localScale.z <1 && isPullUp)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y,
                            this.transform.localScale.z + speed);
            if (this.transform.localScale.z>=1)
            {
                isActive = false;
                isPullUp = false;
            }
        }
        
    }
}
