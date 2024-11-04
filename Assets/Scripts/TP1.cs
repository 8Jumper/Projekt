using UnityEngine;

public class TeleportationPoint : MonoBehaviour
{
    public Transform destination;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = destination.position;
        }
    }
}