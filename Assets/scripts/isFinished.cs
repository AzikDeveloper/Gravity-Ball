using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isFinished : MonoBehaviour
{
    public Transform player;
    public Transform finish;
    bool finished = false;
    
    void OnCollisionEnter(Collision collision)
    {
        if(finished == false && collision.collider.name == "finishChecker")
        {
            Debug.Log("finish");
            finishIt();
            finished = true;
        }
    }
    void finishIt()
    {
        SceneManager.LoadScene(sceneName: "LevelsMenu");
    }
    
}
