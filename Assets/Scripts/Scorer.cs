using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int intHits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        intHits++;
        Debug.Log("You've bumped into things this many times: " + intHits);
    }
}
