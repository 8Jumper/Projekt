using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.EndGame(false);
            Destroy(other.gameObject);
        }
    }
}
