using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float fltXValue = 0.00f;
    float fltYValue = 0.01f;
    float fltZValue = 0.00f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(fltXValue, fltYValue, fltZValue);
    }
}
