using UnityEngine;
using UnityEngine.SceneManagement;

public class VerObstacleMovement : MonoBehaviour
{
    public float speed = 2f; // Velocidad de movimiento del obstáculo
    public string playerTag = "Player"; // Etiqueta del jugador

    // Dirección del movimiento del obstáculo
    private int direction = 1;

    void Update()
    {
        // Movimiento del obstáculo
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime); // Cambio en el eje X

        // Cambiar de dirección cuando alcanza ciertos límites
        if (transform.position.x > 5f)
        {
            direction = -1;
        }
        else if (transform.position.x < -5f)
        {
            direction = 1;
        }
    }

    // Detectar colisión con el jugador
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            // Cargar el nivel 1
            SceneManager.LoadScene("SampleScene");
        }
    }
}
