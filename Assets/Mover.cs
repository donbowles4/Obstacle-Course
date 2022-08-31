using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltXValue = 0.00f;
    [SerializeField] float fltYValue = 0.01f;
    [SerializeField] float fltZValue = 0.00f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(fltXValue, fltYValue, fltZValue);
    }
}
