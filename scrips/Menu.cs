using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void EscenaCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void EscenaInstrucciones()
    {
        SceneManager.LoadScene("Instucciones");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("Menudo");
    }
}
