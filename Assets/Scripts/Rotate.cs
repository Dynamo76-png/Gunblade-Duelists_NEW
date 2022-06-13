using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().rotation = Quaternion.identity;
    }
}