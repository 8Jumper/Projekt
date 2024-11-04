using Unity.VisualScripting;
using UnityEngine;

public class ResourcePickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && (gameObject.GetComponent<Renderer>().material.color == Color.green))
        {
            GameManager.instance.CollectResource();
            Destroy(gameObject);
        }
    }
}
