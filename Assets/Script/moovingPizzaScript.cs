using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moovingPizzaScript : MonoBehaviour
{
    public float moveSpeed = 500;

    public float outOfTheScreen = -2500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePizzas();
        
    }


    

    private void movePizzas()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x <= outOfTheScreen)
        {
            transform.position = new Vector3(3800f, transform.position.y, transform.position.z);
        }
    }
}