using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onClick : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;

    void Start()
    {
        Button playbtn = playButton.GetComponent<Button>();
        Button optionsbtn = optionsButton.GetComponent<Button>();
        Button quitbtn = quitButton.GetComponent<Button>();
        playbtn.onClick.AddListener(play);
        optionsbtn.onClick.AddListener(options);
        quitbtn.onClick.AddListener(quit);
    }
    void play()
    {
        SceneManager.LoadScene(sceneName: "LevelsMenu");
    }
    void options()
    {

    }
    
    void quit()
    {
        Application.Quit();
    }
 
}
