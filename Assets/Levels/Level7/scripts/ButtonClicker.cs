using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    public Animator animator;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ExplodeButton")
        {
            animator.Play("buttonAnim");
        }
    }
}
