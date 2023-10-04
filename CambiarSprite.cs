using UnityEngine;

public class CambiarSprite : MonoBehaviour
{
    public GameObject sprite1; // Referencia al objeto que deseas visualizar al hacer clic
    public GameObject sprite2;
    public float tiempoEspera = 2f; // El tiempo en segundos después del cual se realizará el cambio de objetos

    public int mostrarSprite1;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        mostrarSprite1 = PlayerPrefs.GetInt("ValorSprite");
        StartCoroutine(CambiarObjetosDespuesTiempo());
        
    }

    private System.Collections.IEnumerator CambiarObjetosDespuesTiempo()
    {
        yield return new WaitForSeconds(tiempoEspera); // Esperar el tiempo de espera

        if (mostrarSprite1 == 1)
        {
            sprite1.SetActive(true);
        }
        else if (mostrarSprite1 == 2)
        {
            sprite2.SetActive(true);
        }
    }
}
