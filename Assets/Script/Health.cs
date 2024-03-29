using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MAXHEALTH = 4;
    public int currentHealth;

    public Image[] slicesOfPizza;
    public Sprite health4;
    public Sprite healt3;
    public Sprite healt2;
    public Sprite healt1;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAXHEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void takeDamage(int amount)
    {
        //Play sound

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            //dead
            //death animation
            //gameover
        }
    }

    void showHealth()
    {
        switch (currentHealth)
        {
            //case 4: 
        }
    }

}
