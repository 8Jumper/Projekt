using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzał : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
                else if (hit.collider.gameObject.tag == "TrueResource")
                {
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                }
            }
        }
    }
}