using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update

    bool Entered = false;
    Collider buffer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Entered && Input.GetKey(KeyCode.E)){
            SendMessageUpwards("Grab", buffer);
            SendMessageUpwards("SetHolding", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Entered = true;
        buffer = other;
    }

    private void OnTriggerExit(Collider other)
    {
        Entered = false;
    }
}
