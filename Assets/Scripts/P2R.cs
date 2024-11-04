using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2R : MonoBehaviour
{
    [SerializeField]
    GameObject asd;
    private void OnTriggerEnter(Collider other)
    {
        asd.SetActive(true);
    }
}
