using UnityEngine;

/**
Para saber si el personaje está en el piso o no
Autor: Israel González Huerta
*/

public class EstadoPersonaje : MonoBehaviour
{
    public static bool enPiso { get; private set; } //Propiedades

    void Start()
    {
        enPiso = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        enPiso = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        enPiso = false;
    }

}
