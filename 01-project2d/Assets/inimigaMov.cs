using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigaMov : MonoBehaviour
{
    
    private Rigidbody2D rbd;
    private float speed;    
        
    
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        speed = 5;        
        rbd.velocity = new Vector2(0, -speed);        
    }

    // Update is called once per frame
    void Update()
    {
                
    }
}
