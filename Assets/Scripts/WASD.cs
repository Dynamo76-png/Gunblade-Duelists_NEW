using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float Speed;

    float MovementX;
    float MovementZ;
    public Animator PlayerOne;
    bool IsRunning;
    bool IsGuarding;

    Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
        IsRunning = false;
        Rb = GetComponent<Rigidbody>();

        MovementX = 0;
        MovementZ = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity = new Vector3(MovementX * Speed * Time.deltaTime, 0, MovementZ * Speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.W))
        {
            MovementZ = 1;
            IsRunning = true;
            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MovementZ = -1;
            IsRunning = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MovementX = -1;
            IsRunning = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            MovementX = 1;
            IsRunning = true;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            MovementX = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            MovementX = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            MovementZ = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            MovementZ = 0;
            IsRunning = false;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Speed = 0;
            IsGuarding = true;
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            Speed = 10000;
            IsGuarding = false;
        }

        PlayerOne.SetBool("IsRunning", IsRunning);
        PlayerOne.SetBool("IsGuarding", IsGuarding);
    }
}
