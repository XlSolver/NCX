/*using UnityEngine;

public class PlaneMovements : MonoBehaviour
{
    public float scrollSpeed;

    public float spawnrate = 3;
    public float timer = 0;
    public float groundLenght = 35f;

    public GameObject Ground;


    // Update is called once per frame
    void Update()
    {
        moveBackground();
        generateGround();
    }

   private void moveBackground()
    {
        //Muovi lo sfondo
        transform.position += (Vector3.left * scrollSpeed) * Time.deltaTime;
    }

    private void generateGround()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        } else
        {
            Instantiate(Ground, new Vector2(transform.position.x + groundLenght, transform.position.y), transform.rotation);
            timer = 0;
        }

    
    }
}
*/