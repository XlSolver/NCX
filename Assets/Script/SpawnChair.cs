using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChair : MonoBehaviour
{
    //public List<GameObject> obstacles = new List<GameObject>();

    public GameObject chair;

    public float secondsBeforeSpawn = 5;
    private float timer = 0;
    private float offsetX = 2300;
    private float offsetY = 150;
    private float offsetZ = -80;
    
    //private int obstaclesLimit = 3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        updateTimer();
        spawnObstacle();
    }

    void spawnObstacle()
    {
        if (/*obstacles.Count < obstaclesLimit &&*/ timer > secondsBeforeSpawn)
        {
            GameObject newChair = Instantiate(chair, new Vector3(offsetX, offsetY, offsetZ), Quaternion.Euler(0, 0, -90));
            //obstacles.Add(newChair);
            timer = 0;
            
        }
    }

    private void updateTimer()
    {
        timer += Time.deltaTime;
       
    }

    
}
