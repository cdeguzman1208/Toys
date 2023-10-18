using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour
{
    // Start is called before the first frame update

    public float threshold = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < threshold){
            transform.Translate(Vector3.up * 2 * Time.deltaTime);
        }
    }
}
