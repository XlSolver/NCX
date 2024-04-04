using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MAXHEALTH = 4;
    public int currentHealth;


    private static ShowHearts link;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAXHEALTH;
        link = GetComponent<ShowHearts>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Play sound
        if (collision.gameObject.CompareTag("Chair"))
        {
            currentHealth -= 1;

            Debug.Log("Oh no hai perso una vita!");
            link.showHealth();
        }
        

        if (currentHealth <= 0)
        {
            //dead
            //death animation
            //gameover
        }
        //link.showHealth();
    }
}