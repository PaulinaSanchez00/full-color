using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickearNiño : MonoBehaviour
{
    public GameObject objetoAVisualizar; // Referencia al objeto que deseas visualizar al hacer clic
    public GameObject objetoAVisualizar2; // Referencia al objeto que deseas visualizar al hacer clic


    private void OnMouseDown()
    {
        gameObject.SetActive(false); // Desactivar el objeto
        objetoAVisualizar.SetActive(true); // Activar la visualización del objeto deseado
        objetoAVisualizar2.SetActive(true); // Activar la visualización del objeto deseado

    }
}
