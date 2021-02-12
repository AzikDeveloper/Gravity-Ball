using UnityEngine.SceneManagement;
using UnityEngine;

public class enemyCheckerLevel7 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "red_enemy")
        {
            restart();
        }
    }
    void restart()
    {
        SceneManager.LoadScene(sceneName: "RetryMenu");
    }
}
