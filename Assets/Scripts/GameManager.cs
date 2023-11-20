using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool activeInv;
    [SerializeField] GameObject inventoryPanel;

    // Update is called once per frame
    void Update()
    {
        ActiveInv();
    }

    //Activar o desactivar un Menu
    public void ActiveInv()
    {
        if (activeInv) 
        { 
            inventoryPanel.SetActive(true);
        }
        else
        {
            inventoryPanel.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInv = !activeInv;
        }
    }

    //Codigo de cambio de escena🔁
    public void ChangeScence(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }
    
    //Boton de pausa 🛑
    public void Stop()
    {
        Time.timeScale = 0;
    }
    //Boton de continuar ⏩
    public void Continue()
    {
        Time.timeScale = 1;
    }
    //Boton de Reiniciar 🔁
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //Boton de Cerrar ❌
    public void Cerrar()
    {
        Application.Quit();
        Debug.Log("Cerrado");
    }
}
