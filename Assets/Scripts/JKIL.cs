using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JKIL : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovementZ = 1;
            IsRunning = true;

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovementZ = -1;
            IsRunning = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovementX = -1;
            IsRunning = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovementX = 1;
            IsRunning = true;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            MovementX = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MovementX = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            MovementZ = 0;
            IsRunning = false;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            MovementZ = 0;
            IsRunning = false;
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            Speed = 0;
            IsGuarding = true;
        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            Speed = 10000;
            IsGuarding = false;
        }
        PlayerOne.SetBool("IsRunning", IsRunning);
        PlayerOne.SetBool("IsGuarding", IsGuarding);
    }
}
