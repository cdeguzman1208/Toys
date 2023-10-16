using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalAcceptor : MonoBehaviour
{
    // Start is called before the first frame update
    bool holding;
    Transform original;
    void Start()
    {
        holding = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Drop();
    }

    void Grab(Collider buffer){
        original = gameObject.transform.parent;
        gameObject.transform.parent = buffer.gameObject.transform;
        // Vector3 bestPos = new Vector3(0.5f, 0.5f, -0.5f);
        // gameObject.transform.position = bestPos;
        //couldn't get the best value here
        //but this can be tweaked to move around the position of the hoe
    }

    void Drop(){ //This is the wrong way of doing this instead we should instantiate a new one and delete this one I think
        if(holding == true && Input.GetKey(KeyCode.E)){
            gameObject.transform.parent = original;
        }
    }

    void SetHolding(bool ifHolding){
        holding = ifHolding;
    }
}
