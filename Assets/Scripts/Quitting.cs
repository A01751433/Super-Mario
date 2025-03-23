/**
Cierra la aplicación
Israel González Huerta
A01751433
*/

using UnityEngine;

//Código tomado de HK7a, en el video "Unity How To Make a Quit Button"
//https://www.youtube.com/watch?v=2BdgUgh_yxA


public class Quitting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Quitgame()
    {
        print("quit game");
        Debug.Log("quit game");
        Application.Quit();
    }
}
