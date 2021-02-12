using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleporter_blue2;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "teleporter_blue1")
        {
            transform.position = teleporter_blue2.position;
        }
    }
}
