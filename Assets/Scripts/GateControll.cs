using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControll : MonoBehaviour
{
    [SerializeField]
    GameObject brama1;
    [SerializeField] 
    GameObject brama2;
    private void OnTriggerEnter(Collider other)
    {
        brama1.SetActive(false);
        brama2.SetActive(true);
    }
}
