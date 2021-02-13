using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    public float rotSpeed = 10f;
    void Update()
    {
        transform.Rotate(0.1f * rotSpeed * Time.deltaTime,  rotSpeed * Time.deltaTime, -0.1f * rotSpeed * Time.deltaTime);
    }
}
