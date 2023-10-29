using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void IrAJuego()
    {
        Debug.Log("Entraste al juego");
        SceneManager.LoadScene("MainScene");
    }

    public void RegresarAlMenu()
    {
        Debug.Log("Regresaste al menu");
        SceneManager.LoadScene("SampleScene");
    }

    public void IrAOpciones()
    {
        Debug.Log("Entraste al opciones");
        SceneManager.LoadScene("OptionsScene");
    }




}
