using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isFinishedLevel9 : MonoBehaviour
{
    bool finished = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!finished && collision.collider.tag == "finishChecker")
        {
            Debug.Log("finish");
            finishIt();
            finished = true;
        }
        else if(!finished && collision.collider.tag == "red_enemy")
        {
            SceneManager.LoadScene(sceneName: "RetryMenu");
        }
    }
    void finishIt()
    {
        SceneManager.LoadScene(sceneName: "LevelsMenu");
    }

}