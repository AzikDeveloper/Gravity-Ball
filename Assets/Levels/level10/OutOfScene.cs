
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfScene : MonoBehaviour
{
    public Transform ball;
    void Update()
    {
        if (ball.position.y < -10)
        {
            retry();
        }
    }
    void retry()
    {
        SceneManager.LoadScene(sceneName: "RetryMenu");
    }
}
