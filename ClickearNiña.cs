using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickearNiña : MonoBehaviour
{
    public GameObject objetoAVisualizar; // Referencia al objeto que deseas visualizar al hacer clic
   
    private void OnMouseDown()
    {
        gameObject.SetActive(false); // Desactivar el objeto
        objetoAVisualizar.SetActive(true); // Activar la visualización del objeto deseado

    }
}