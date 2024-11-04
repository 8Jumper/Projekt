using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTP : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance.resourcesCollected >= 4)
                Time.timeScale = 0;
        }
    }
}