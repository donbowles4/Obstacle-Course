using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float fltXValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltXValue, 0, fltZValue);
    }
}
