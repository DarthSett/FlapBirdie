using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float jumpHeight = 2;
    private Rigidbody2D MyScriptsRigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        MyScriptsRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
           MyScriptsRigidbody2D.velocity = Vector2.up * jumpHeight;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("SWEET SWEET DEATH!!");
        Destroy(this.gameObject);
    }
}
