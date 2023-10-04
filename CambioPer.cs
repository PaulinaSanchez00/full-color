using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPer : MonoBehaviour
{
    public GameObject objetoActivo; // El objeto que deseas activar
    public GameObject objetoInactivo; // El objeto que deseas desactivar
    public float tiempoEspera = 2f; // El tiempo en segundos después del cual se realizará el cambio de objetos

    private void Start()
    {
        StartCoroutine(CambiarObjetosDespuesTiempo());
    }

    private System.Collections.IEnumerator CambiarObjetosDespuesTiempo()
    {
        yield return new WaitForSeconds(tiempoEspera); // Esperar el tiempo de espera

        objetoActivo.SetActive(true); // Activar el nuevo objeto
        objetoInactivo.SetActive(false); // Desactivar el objeto anterior
    }
}
