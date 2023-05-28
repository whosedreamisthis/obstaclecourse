using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10;
    float xValue = 0.01f;
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        Move();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Use arrows to move player around.");
        Debug.Log("Don't hit the walls");
    }

    void Move()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, 0, zValue);
    }

}
