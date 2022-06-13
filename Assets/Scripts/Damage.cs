using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public GameObject Health;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) == true)
        {
            if (Health.GetComponent<Health>().playerID == 2)
            {
                float distance = (enemy.transform.position - gameObject.transform.position).magnitude;
                if (distance <= 70 && Input.GetKey(KeyCode.Keypad5) == false && Input.GetKey(KeyCode.K) == false)
                {
                    Debug.Log("Player 2 Hit");
                    {
                        Health.GetComponent<Health>().TakeDamage(1);
                    }
                }
                
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) == true)
        {
            if (Health.GetComponent<Health>().playerID == 1)
            {
                float distance = (enemy.transform.position - gameObject.transform.position).magnitude;
                if (distance <= 70 && Input.GetKey(KeyCode.K) == false && Input.GetKey(KeyCode.Keypad5) == false) 
                {
                    Debug.Log("Player 1 Hit");
                    {
                        Health.GetComponent<Health>().TakeDamage(1);
                    }
                }

            }
        }
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (Health.GetComponent<Health>().playerID == 1)
        {
            if (collision.collider.CompareTag("Player Two"))
            {
                Debug.Log("Player 2 Hit");
            }
        }
        if (Health.GetComponent<Health>().playerID == 2)
        {
            if (collision.collider.CompareTag("Player One"))
            {
                Debug.Log("Player 1 Hit");
            }
        }
    }
    */
            
}
        


