using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Animator PlayerOne;

    // Start is called before the first frame update
    void Start()
    {
        PlayerOne = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            PlayerOne.SetBool("IsAttacking", true);
        }



        if (!Input.GetKey(KeyCode.Keypad4))
        {
            PlayerOne.SetBool("IsAttacking", false);
        }

    }



}
