using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool pauseMenu;
    [SerializeField] GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActivePauseMenu();
    }

    public void ActivePauseMenu()
    {
        if (pauseMenu)
        {
            pausePanel.SetActive(true);
            Stop();
        }
        else
        {
            pausePanel.SetActive(false);
            Continue();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu = !pauseMenu;
        }
    }

    public void Stop()
    {
        Time.timeScale = 0;
    }
    //Boton de continuar ⏩
    public void Continue()
    {
        Time.timeScale = 1;
    }
}
