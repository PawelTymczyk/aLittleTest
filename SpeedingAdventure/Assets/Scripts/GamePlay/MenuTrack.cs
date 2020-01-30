using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTrack : MonoBehaviour
{
   
    public GameObject menu;
    public int CurrentScene;
    private bool IsMenu = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsMenu == true)
            {
                menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                menu.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void MenuScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void OptionScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }
    public void ReloadCurrentScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(CurrentScene);
    }

    public void ShowOff()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}
