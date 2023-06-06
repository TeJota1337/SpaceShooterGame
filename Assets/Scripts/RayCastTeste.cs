using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTeste : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction*1000, Color.red);
   

        if (Physics.Raycast(ray, out hit))
        {
            transform.position = hit.point;

            // Do something with the object that was hit by the raycast.
        }
    }
}
    