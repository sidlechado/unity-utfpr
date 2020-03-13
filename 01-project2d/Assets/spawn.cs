using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject NPC;    
    private float height;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
       height = Camera.main.orthographicSize;
       width = height * Camera.main.aspect;
       InvokeRepeating("createNPC", 2, 1);
    }

    public void createNPC()
    {
        float posX = Random.Range(-width, width);
        Instantiate(NPC, new Vector2(posX, height+2), Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
