using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float fltTimeToWait = 3f;
    void Update()
    {
        if(Time.time > fltTimeToWait)
        {
            Debug.Log("3 seconds has elapsed");
        }
    }
}
