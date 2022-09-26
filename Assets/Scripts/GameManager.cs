using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public GameObject PausePanel;
   public GameObject PauseButton;
   public GameObject WinPanel;

   public void Start(){
        PauseButton.SetActive(true);
        PausePanel.SetActive(false);
        WinPanel.SetActive(false);
   }
   public void PausePanelOn()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !(PausePanel.activeSelf))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0.0f;
        }
        else if (PausePanel.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1.0f;
            PausePanel.SetActive(false);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1.0f;
        PausePanel.SetActive(false);
    }
    public void ReloadMainScene()
    {
        SceneManager.LoadScene("Main");
        Time.timeScale = 1.0f;
    }
}
