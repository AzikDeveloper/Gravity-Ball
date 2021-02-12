using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burner : MonoBehaviour
{
    public GameObject flame;
    public GameObject explotion;
    public Transform finish;
    public Retry retryer;
    public ShakeCamera shaker;
    public LayerMask burnableMask;
    float countdownExplotion = 2f;
    bool isBurnabe,isBurnableFromTrigger,fireStarted,isExploded;

    void Start()
    {
        retryer = retryer.GetComponent<Retry>();
        shaker = shaker.GetComponent<ShakeCamera>();
        flame.SetActive(false);
        explotion.SetActive(false);
    }
    void Update()
    {
        if (!isExploded)
        {
            isBurnabe = (finish.position-transform.position).magnitude < 1.5f;
            isBurnableFromTrigger = Physics.CheckSphere(transform.position, 1f, burnableMask);
            Debug.Log(isBurnabe);
            Debug.Log(isBurnableFromTrigger);
            if (isBurnabe || fireStarted || isBurnableFromTrigger)
            {
                fireStarted = true;
                countdownExplotion -= Time.deltaTime;
                if (countdownExplotion <= 0f)
                {
                    isExploded = true;
                    explotion.SetActive(true);
                    if (isBurnableFromTrigger)
                    {
                        explosionForce();
                    }
                    shaker.Play();
                    Invoke("setdefaultExplotion",2f);
                }
                flame.SetActive(true);

            }
        }
        
    }
    void setdefaultExplotion()
    {
        explotion.SetActive(false);
        if (isBurnabe && !isBurnableFromTrigger)
        {
            retryer.retry();
        }
        Invoke("stopFire", 2f);
    }
    void stopFire()
    {
        flame.SetActive(false);
    }
    void explosionForce()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, 15f);

        foreach(Collider eachCollider in colliders)
        {
            Rigidbody theObject = eachCollider.GetComponent<Rigidbody>();
            if(theObject != null && theObject.name != "barrel")
            {
                theObject.constraints = RigidbodyConstraints.None;
                theObject.constraints = RigidbodyConstraints.FreezePositionX;
                theObject.AddExplosionForce(700f, transform.position, 5);
            }
        }
    }



}
