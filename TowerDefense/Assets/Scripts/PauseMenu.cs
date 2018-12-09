using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;
    public SceneFader scenefader;

    public string menuStringName = "MainMenu";

	void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }
    public void Toggle()
    {
        //ui.activeSelf is a boolean which is true or false
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            //freeze time
            Time.timeScale = 0f;

        }
        else{
            Time.timeScale = 1f;
        }
    }
    public void Retry()
    {
        Toggle();
        scenefader.FadeTo(SceneManager.GetActiveScene().name);

    }
    public void Menu()
    {
        Toggle();
        scenefader.FadeTo(menuStringName);
    }
}
