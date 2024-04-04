using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtener el componente Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada del teclado
        float moveHorizontal = -Input.GetAxis("Horizontal"); // Invertir la dirección horizontal
        float moveVertical = -Input.GetAxis("Vertical"); // Invertir la dirección vertical

        // Calcular el vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplicar el movimiento al Rigidbody
        rb.velocity = movement * speed;
    }
}
