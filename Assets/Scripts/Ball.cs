using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float randomFactor = 0.5f; // Wp�yw losowo�ci na zmian� kierunku

    private Rigidbody rb;
    public Vector3 impulseForce = new Vector3(50f, 0, 0);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(impulseForce, ForceMode.Impulse);
        rb.velocity = impulseForce;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Pobierz aktualn� pr�dko�� kuli
        Vector3 currentVelocity = rb.velocity*1.2f;

        // Wygeneruj losowy wektor, kt�ry lekko zmieni kierunek
        Vector3 randomDirection = new Vector3(
            Random.Range(-randomFactor, randomFactor),
            Random.Range(-randomFactor, randomFactor),
            Random.Range(-randomFactor, randomFactor)
        );

        // Zmie� kierunek pr�dko�ci, dodaj�c losowy kierunek
        Vector3 newVelocity = currentVelocity + randomDirection;

        // Zaktualizuj pr�dko�� kuli
        rb.velocity = newVelocity.normalized * currentVelocity.magnitude;
    }
}
