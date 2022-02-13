using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    public GameManager gameManager;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Vector3 temp = transform.position;
        temp.y +=  Random.Range(-2, 2);
        transform.position = temp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
        if (transform.position.x < -9)
        {
            Destroy(this.gameObject);
        } 
            
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        gameManager.Score += 1;
        Debug.Log("Score: " + gameManager.Score);
    }
}