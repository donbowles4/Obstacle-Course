using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float fltMoveSpeed = 10.0f;
    void Start()
    {
        PrintInstruction();    
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float fltXValue = Input.GetAxis("Horizontal") * Time.deltaTime * fltMoveSpeed;
        float fltZValue = Input.GetAxis("Vertical") * Time.deltaTime * fltMoveSpeed;
        transform.Translate(fltXValue, 0, fltZValue);
    }
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD or Arrow Keys to Move");
        Debug.Log("Don't hit the walls");
    }
}
