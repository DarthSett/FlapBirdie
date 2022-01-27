using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    
    public float waitTime = 2.0f;
    private float timer = 0.0f;
    public GameObject ObstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > waitTime)
        {
            Instantiate(ObstaclePrefab, transform.position, Quaternion.identity);
            timer = timer - waitTime;
        }
    }
}
