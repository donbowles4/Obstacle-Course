using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float fltXValue = Input.GetAxis("Horizontal");
        float fltZValue = Input.GetAxis("Vertical");
        transform.Translate(fltXValue, 0, fltZValue);
    }
}
