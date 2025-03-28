/*
Maneja la conducta de los botones en la pantalla de juego
Israel González Huerta
A01751433
*/

using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class JuegoControlador : MonoBehaviour
{
    private UIDocument menu;
    private Button boton_menu; 

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        boton_menu = root.Q<Button>("Boton_menu");

        boton_menu.RegisterCallback<ClickEvent, String>(MostrarMenu, "Scenemenu");
    }

    private void MostrarMenu(ClickEvent evt, String escena)
    {
        SceneManager.LoadScene(escena);
    }
}
