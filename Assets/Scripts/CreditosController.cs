/*
Controla la conducta de los botones en la pantalla de créditos
Israel González Huerta
A01751433
*/

using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class CreditosController : MonoBehaviour
{
    private UIDocument menu;
    private Button boton_regresar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        boton_regresar = root.Q<Button>("Regresar");

        boton_regresar.RegisterCallback<ClickEvent, String>(IniciarJuego, "SceneMenu");
    }

    private void IniciarJuego(ClickEvent evt, String escena)
    {
        SceneManager.LoadScene(escena);
    }
}
