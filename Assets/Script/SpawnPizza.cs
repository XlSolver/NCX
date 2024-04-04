
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPizza : MonoBehaviour
{



    public GameObject PizzaDesign;

    private List<GameObject> pizzas = new List<GameObject>();

    public float xOffset = 1.5f;
    
    public int limitNumberForPizzaCanvas;    

    // Start is called before the first frame update
    void Start()
    {
        generateSomePizzaCanvas();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //TO DO: it generates too many objects
    private void generateSomePizzaCanvas()
    {
        for (int i = 0; i < limitNumberForPizzaCanvas; i++)
        {
            
            GameObject pizza = Instantiate(PizzaDesign, new Vector3(transform.position.x + (i * transform.position.x * xOffset), transform.position.y, transform.position.z), Quaternion.identity); //new istance
            pizzas.Add(pizza); //Add the istance into the list

            Debug.Log("Pizzas count: " + pizzas.Count);
            Debug.Log("Limit number: " + limitNumberForPizzaCanvas);
                
        }
    }


}