using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
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
        if (Input.GetKey("j"))
        {
            PlayerOne.SetBool("IsAttacking", true);
        }
       


        if (!Input.GetKey("j"))
        {
            PlayerOne.SetBool("IsAttacking", false);
        }
     
    }

         

   }
