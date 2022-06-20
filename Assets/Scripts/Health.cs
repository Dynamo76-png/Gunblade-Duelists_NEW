using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    string SceneToLoad;
    public Slider Bar;
    public int playerID;
    public int maxHealth = 30;
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Bar.GetComponent<Slider>().value = currentHealth;
    }
    // Update is called once per frame
    void Update()
    {
              
       
        if (currentHealth == 0)
        {
            if (playerID == 1)
            {
                SceneToLoad = ("Victory2");
                SceneManager.LoadScene(SceneToLoad);
            }
            if (playerID == 2)
            {
                SceneToLoad = ("Victory1");
                SceneManager.LoadScene(SceneToLoad);
            }
            Destroy(gameObject);
        }
    }
}
