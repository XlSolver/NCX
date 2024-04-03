using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyChair : MonoBehaviour
{
    

    private float outOfTheScreen = -1500;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destroyItemAtPlace();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
        
        
    }

    private void destroyItemAtPlace()
    {
        if (transform.position.x < outOfTheScreen)
        {
            Destroy(gameObject);
            
        }
    }
}
