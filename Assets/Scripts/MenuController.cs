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

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        boton_quit = root.Q<Button>("Boton_quit");
        boton_jugar = root.Q<Button>("Boton_jugar");


        boton_quit.RegisterCallback<ClickEvent>(Quitgame);
        boton_jugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "SceneGame");

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
}
