using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new  MeshRenderer renderer;
    Rigidbody rb;
    public float timeTowait; // object will wait in the air floating 
   
    void Start()  // Start is called before the first frame update
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    
    void Update() // Update is called once per frame
    {
        if(Time.time > timeTowait)
        {
            
            renderer.enabled = true;
            rb.useGravity = true;
            
        }
    }
}
