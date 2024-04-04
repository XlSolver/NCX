using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHearts : MonoBehaviour
{

    public Sprite health4;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;
    public Image healthImage;

    private Health healthScript; //Reference to health script

    void OnEnable()
    {
        healthScript = GetComponent<Health>();
        healthImage = GetComponent<Image>();
    }

    //healthImages[currentHealth].sprite = healthImages[currentHealth].GetComponent<SpriteRenderer>().sprite; // Set sprite directly on the Image component

    public void showHealth()
    {
        Debug.Log("Lo switch è stato chiamato");
        if (healthScript is not null )
        {

            switch (healthScript.currentHealth)
            {
                case 4:
                    {
                        if (healthImage is not null)
                        {
                            healthImage.overrideSprite = health4;
                            break;
                        }
                        else
                        {
                            healthImage.sprite = health4;
                            break;
                        }
                    }
                case 3:
                    {
                        if (healthImage is not null)
                        {
                            healthImage.overrideSprite = health3;
                            break;
                        }
                        else
                        {
                            healthImage.sprite = health3;
                            break;
                        }
                    }
                case 2:
                    {
                        if (healthImage is not null)
                        {
                            healthImage.overrideSprite = health2;
                            break;
                        }
                        else
                        {
                            healthImage.sprite = health2;
                            break;
                        }
                    }
                case 1:
                    {
                        if (healthImage is not null)
                        {
                            healthImage.overrideSprite = health1;
                            break;
                        }
                        else
                        {
                            healthImage.sprite = health1;
                            break;
                        }
                    }
                case 0:
                    {
                        //Game over screen
                        break;
                    }
            }
        }
        else
        {
            Debug.LogError("healthScript reference is null!"); // Log an error message
        }
    }
}
