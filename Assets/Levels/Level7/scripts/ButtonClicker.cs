using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    public Animator animator;
    public ParticleSystem enemyExplotionEffect;

    public GameObject enem1;
    public GameObject enem2;


 
    bool isClicked = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isClicked && collision.collider.tag == "ExplodeButton")
        {
            animator.Play("buttonAnim");
            Invoke("explodeEnemy", 0.5f);
            isClicked = true;
            Debug.Log("boom");
        }
    }

    void explodeEnemy()
    {
        ParticleSystem exp1 = Instantiate(enemyExplotionEffect, enem1.transform.position, enem1.transform.rotation);
        ParticleSystem exp2 = Instantiate(enemyExplotionEffect, enem2.transform.position, enem2.transform.rotation);
        Destroy(enem1);
        Destroy(enem2);
        Destroy(exp1.transform.gameObject,1.5f);
        Destroy(exp2.transform.gameObject,1.5f);

    }
  
}
