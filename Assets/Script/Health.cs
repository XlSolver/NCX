using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MAXHEALTH = 4;
    public int currentHealth;

    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAXHEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Play sound
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            currentHealth -= 1;
        }
        

        if (currentHealth <= 0)
        {
            //dead
            //death animation
            //gameover
        }
        Invoke("showHealth", 1.0f);
    }
}