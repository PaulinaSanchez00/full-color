using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string nombreEscena; // Nombre de la escena a la que deseas cambiar

    Animator animacion; // Referencia a la animación adjunta al objeto

    private void Start()
    {
        animacion = GetComponent<Animator>(); // Obtener la referencia a la animación
    }

    private void Update()
    {
        AnimatorStateInfo stateInfo = animacion.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.normalizedTime >= 1) // Verificar si la animación ha terminado de reproducirse
        {
            SceneManager.LoadScene(nombreEscena); // Cambiar a la escena deseada
        }
    }
}