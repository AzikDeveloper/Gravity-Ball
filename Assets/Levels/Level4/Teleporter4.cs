using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter4 : MonoBehaviour
{
    public GameObject teleporter_blue2;
    void Start()
    {
        teleporter_blue2.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "teleporter_blue1")
        {
            teleporter_blue2.SetActive(true);
            Invoke("teleport", 1f);
            
        }
    }
    void teleport()
    {
        transform.position = teleporter_blue2.transform.position;
    }
}
