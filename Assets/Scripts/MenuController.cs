/*
Maneja la conducta de los botones en el menú principal
Israel González Huerta
A01751433
*/

using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MenuController : MonoBehaviour
{
    private UIDocument menu;
    private Button boton_quit;
    private Button boton_jugar;
    private Button boton_ayuda;
    private Button boton_creditos;
    private Button boton_cerr_ayuda;
    private VisualElement cont_botones;
    private VisualElement cont_ayuda;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        boton_quit = root.Q<Button>("Boton_quit");
        boton_jugar = root.Q<Button>("Boton_jugar");
        boton_ayuda = root.Q<Button>("Boton_ayuda");
        cont_ayuda = root.Q<VisualElement>("Container_ayuda");
        boton_cerr_ayuda = root.Q<Button>("Cerrar_ayuda");
        boton_creditos = root.Q<Button>("Boton_creditos");
        cont_botones = root.Q<VisualElement>("Botones");


        cont_ayuda.style.display = DisplayStyle.None; // start hidden


        boton_quit.RegisterCallback<ClickEvent>(Quitgame);
        boton_jugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "SceneGame");
        boton_ayuda.RegisterCallback<ClickEvent>(abrAyuda);
        boton_cerr_ayuda.RegisterCallback<ClickEvent>(cerAyuda);
        boton_creditos.RegisterCallback<ClickEvent, String>(IniciarJuego, "SceneCredits");
    }

    private void IniciarJuego(ClickEvent evt, String escena)
    {
        SceneManager.LoadScene(escena);
    }
    private void Quitgame(ClickEvent evt)
    {
        //print("Presionado");
        Application.Quit();
    }

    // Oculta los botones y abre la pantalla de ayuda
    private void abrAyuda(ClickEvent evt){
        cont_botones.style.display = DisplayStyle.None;
        cont_ayuda.style.display = DisplayStyle.Flex;
    }

    // Oculta la pantalla de ayuda y muestra los botones del menú
    private void cerAyuda(ClickEvent evt){
        cont_botones.style.display = DisplayStyle.Flex;
        cont_ayuda.style.display = DisplayStyle.None;
    }
}
