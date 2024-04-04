using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    // Etiqueta del objeto jugador
    public string playerTag = "Player";

    // Nombre del siguiente nivel
    public string nextLevelName = "Nivel2";

    // Este método se llama cuando otro objeto colisiona con este objeto
    private void OnTriggerEnter(Collider other)
    {
        // Comprobar si el objeto que colisiona tiene la etiqueta "Player"
        if (other.CompareTag(playerTag))
        {
            // Cargar el siguiente nivel
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
