using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public int Speed = 0;
    Vector3 DirectionPlayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DirectionPlayer = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            DirectionPlayer += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.S))
        {
            DirectionPlayer += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A))
        {
            DirectionPlayer += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            DirectionPlayer += Vector3.right;
        }

        Movement(DirectionPlayer);
    }

    void Movement(Vector3 Direction)
    {
        transform.Translate(Direction * Speed * Time.deltaTime);
    }
}
