using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float fltXAngle = 0f;
    [SerializeField] float fltYAngle = 8f;
    [SerializeField] float fltZAngle = 0f;
    void Update()
    {
        transform.Rotate(fltXAngle,fltYAngle,fltZAngle);
    }
}
