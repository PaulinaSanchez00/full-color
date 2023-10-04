using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioIntro : MonoBehaviour
{
    public string nombreEscena; // El nombre de la escena a la que deseas cambiar
    public float tiempoEspera = 2f; // El tiempo en segundos después del cual se realizará el cambio de escena

    private void Start()
    {
        StartCoroutine(CambiarEscenaDespuesTiempoCorrutina());
    }

    private System.Collections.IEnumerator CambiarEscenaDespuesTiempoCorrutina()
    {
        yield return new WaitForSeconds(tiempoEspera); // Esperar el tiempo de espera

        SceneManager.LoadScene(nombreEscena); // Cambiar a la escena deseada
    }
}
