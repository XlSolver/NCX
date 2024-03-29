using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairMovements : MonoBehaviour
{
    public float scrollSpeed;
    public GameObject chair;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * scrollSpeed) * Time.deltaTime;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && chair != null)
        {
            Destroy(chair);
        }
    }
}
