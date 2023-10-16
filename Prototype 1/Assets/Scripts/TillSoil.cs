using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TillSoil : MonoBehaviour
{
  public GameObject soil;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction);

            if (Physics.Raycast (ray, out hit)) {
                if(hit.collider.gameObject.name == "Garden") {
                    Debug.Log("here");
                    Instantiate(soil, new Vector3(hit.point.x, 0.5f, hit.point.z), Quaternion.identity);
                }
            }
        }
    }
}
