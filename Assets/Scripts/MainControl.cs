using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControl : MonoBehaviour
{
    public float Speed;

    float MovementX;
    float MovementZ;

    Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementX = Input.GetAxisRaw("Horizontal");
        MovementZ = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector3(MovementX * Speed * Time.deltaTime, 0, MovementZ * Speed * Time.deltaTime);
    }
}