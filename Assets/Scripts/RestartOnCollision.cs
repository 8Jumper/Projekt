using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Sprawd�, czy obiekt, z kt�rym koliduje kula, to gracz
        if (collision.gameObject.CompareTag("Player"))
        {
            // Prze�aduj aktualn� scen�, co powoduje restart gry
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
