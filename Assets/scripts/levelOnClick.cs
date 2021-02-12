using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelOnClick : MonoBehaviour
{
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;
    public Button level4Button;
    public Button level5Button;
    public Button level6Button;
    public Button level7Button;
    public Button level8Button;
    public Button level9Button;
    public Button level10Button;

    void Start()
    {
        Button button1 = level1Button.GetComponent<Button>();
        Button button2 = level2Button.GetComponent<Button>();
        Button button3 = level3Button.GetComponent<Button>();
        Button button4 = level4Button.GetComponent<Button>();
        Button button5 = level5Button.GetComponent<Button>();
        Button button6 = level6Button.GetComponent<Button>();
        Button button7 = level7Button.GetComponent<Button>();
        Button button8 = level8Button.GetComponent<Button>();
        Button button9 = level9Button.GetComponent<Button>();
        Button button10 = level10Button.GetComponent<Button>();

        button1.onClick.AddListener(btn1);
        button2.onClick.AddListener(btn2);
        button3.onClick.AddListener(btn3);
        button4.onClick.AddListener(btn4);
        button5.onClick.AddListener(btn5);
        button6.onClick.AddListener(btn6);
        button7.onClick.AddListener(btn7);
        button8.onClick.AddListener(btn8);
        button9.onClick.AddListener(btn9);
        button10.onClick.AddListener(btn10);
    }
    void goToLevel(int i)
    {
            SceneManager.LoadScene(sceneName:"Level"+i.ToString());
    }
    void btn1()
    {
        goToLevel(1);
    }
    void btn2()
    {
        goToLevel(2);
    }
    void btn3()
    {
        goToLevel(3);
    }
    void btn4()
    {
        goToLevel(4);
    }
    void btn5()
    {
        goToLevel(5);
    }
    void btn6()
    {
        goToLevel(6);
    }
    void btn7()
    {
        goToLevel(7);
    }
    void btn8()
    {
        goToLevel(8);
    }
    void btn9()
    {
        goToLevel(9);
    }
    void btn10()
    {
        goToLevel(10);
    }

}
