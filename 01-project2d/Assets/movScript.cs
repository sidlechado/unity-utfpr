using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
