using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float fltTimeToWait = 3f;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }
    void Update()
    {
        if(Time.time > fltTimeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
