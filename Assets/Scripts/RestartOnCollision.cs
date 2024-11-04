using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // SprawdŸ, czy obiekt, z którym koliduje kula, to gracz
        if (collision.gameObject.CompareTag("Player"))
        {
            // Prze³aduj aktualn¹ scenê, co powoduje restart gry
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
