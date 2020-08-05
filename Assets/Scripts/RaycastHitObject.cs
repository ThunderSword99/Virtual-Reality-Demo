using UnityEngine;
using System.Collections;

public class RaycastHitObject : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("Switcher"))
                {
                    GameObject thing = hit.collider.GetComponent<Switcher>().thing;
                    if (thing.CompareTag("CeilingFan"))
                    {
                        thing.GetComponent<Ceiling>().TurnOnOff();
                    }
                    if (thing.CompareTag("Light"))
                    {
                        if (thing.activeSelf)
                        {
                            thing.SetActive(false);
                        }
                        else
                        {
                            thing.SetActive(true);
                        }
                    }
                }
                if (hit.collider.CompareTag("Door"))
                {
                    GameObject thing = hit.collider.GetComponent<DoorHinge>().doorHinge;
                    if (thing.transform.rotation.z == 0)
                    {
                        thing.transform.Rotate(0,0,90);
                    }
                    else
                    {
                        thing.transform.Rotate(0,0,-90);
                    }
                    
                }
            }
        }
    }
}