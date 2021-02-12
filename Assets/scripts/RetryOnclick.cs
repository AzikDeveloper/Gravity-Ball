using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryOnclick : MonoBehaviour
{
    public Button restartButton;
    public Button optionsButton;
    public Button quitButton;
    void Start()
    {
        Button restartBTN = restartButton.GetComponent<Button>();
        Button optionsBTN = optionsButton.GetComponent<Button>();
        Button quitBTN = quitButton.GetComponent<Button>();
        restartBTN.onClick.AddListener(restart);
        optionsBTN.onClick.AddListener(options);
        quitBTN.onClick.AddListener(quit);
    }
    void restart()
    {
        SceneManager.LoadScene(sceneName:"Level3");
    }
    void options()
    {
        
    }
    void quit()
    {
        Application.Quit();
    }
}
