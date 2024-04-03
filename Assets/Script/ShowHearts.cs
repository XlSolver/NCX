using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHearts : MonoBehaviour
{
    

    public Image healthImage;
    public Sprite health4;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;

    private Health healthScript;

    public void showHealth()
    {
        switch (healthScript.currentHealth)
        {
            case 4:
                {
                    healthImage.sprite = health4;
                    break;
                }
            case 3:
                {
                    healthImage.sprite = health3;
                    break;
                }
            case 2:
                {
                    healthImage.sprite = health2;
                    break;
                }
            case 1:
                {
                    healthImage.sprite = health1;
                    break;
                }
            case 0:
                {
                    //Game over screen
                    break;
                }
        }
    }
}
