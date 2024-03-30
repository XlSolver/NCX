using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int MAXHEALTH = 4;
    public int currentHealth;

    public Image[] slicesOfPizza;
    public Sprite health4;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MAXHEALTH;
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TakeDamage(int amount)
    {
        // Play sound

        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            // Dead
            // Death animation
            // Game over
        }

        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        // Assicurati che l'array delle immagini sia valido e che l'indice sia nel range corretto
        if (slicesOfPizza != null && currentHealth >= 0 && currentHealth < slicesOfPizza.Length)
        {
            // Disattiva tutte le immagini
            foreach (Image slice in slicesOfPizza)
            {
                slice.gameObject.SetActive(false);
            }

            // Attiva solo le immagini necessarie per rappresentare la salute corrente
            for (int i = 0; i < currentHealth; i++)
            {
                slicesOfPizza[i].gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("Array delle immagini UI non assegnato nell'Editor Unity o indice non valido.");
        }
    }
}
