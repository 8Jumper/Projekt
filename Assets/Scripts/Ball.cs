using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float randomFactor = 0.5f; // Wp³yw losowoœci na zmianê kierunku

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
        // Pobierz aktualn¹ prêdkoœæ kuli
        Vector3 currentVelocity = rb.velocity*1.2f;

        // Wygeneruj losowy wektor, który lekko zmieni kierunek
        Vector3 randomDirection = new Vector3(
            Random.Range(-randomFactor, randomFactor),
            Random.Range(-randomFactor, randomFactor),
            Random.Range(-randomFactor, randomFactor)
        );

        // Zmieñ kierunek prêdkoœci, dodaj¹c losowy kierunek
        Vector3 newVelocity = currentVelocity + randomDirection;

        // Zaktualizuj prêdkoœæ kuli
        rb.velocity = newVelocity.normalized * currentVelocity.magnitude;
    }
}
