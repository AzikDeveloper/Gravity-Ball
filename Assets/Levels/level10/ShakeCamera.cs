using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    bool shake = false;
    float countdown = 0.05f;
    public GameObject TheObject;
    bool firstShake, secondShake;
    public int MaxShakeCount = 4;
    public float shakeSpeed = 20f;
    float ShakeCountX = 0f;
    float x,y, z;
    Vector3 firstpos;
    void Start()
    {
        firstpos = TheObject.transform.position;
    }

    
    void Update()
    {
        if (shake)
        {
            if (firstShake)
            {
                if (countdown > 0)
                {
                    x = TheObject.transform.position.x+Time.deltaTime*shakeSpeed;
                    y = TheObject.transform.position.y;
                    z = TheObject.transform.position.z;
                    TheObject.transform.position = new Vector3(x, y, z);
                    countdown -= Time.deltaTime;
                }
                else
                {
                    firstShake = false;
                    countdown = 0.05f;
                    secondShake = true;
                    ShakeCountX++;
                    if (ShakeCountX > MaxShakeCount-1)
                    {
                        firstShake = false;
                        secondShake = false;
                    }
                }
            }
            else if (secondShake)
            {
                if (countdown > 0)
                {
                    x = TheObject.transform.position.x-Time.deltaTime*shakeSpeed;
                    y = TheObject.transform.position.y;
                    z = TheObject.transform.position.z;
                    TheObject.transform.position = new Vector3(x, y, z);
                    countdown -= Time.deltaTime;
                }
                else
                {
                    secondShake = false;
                    countdown = 0.05f;
                    firstShake = true;
                    ShakeCountX++;
                    if (ShakeCountX > MaxShakeCount-1)
                    {
                        firstShake = false;
                        secondShake = false;
                        TheObject.transform.position = firstpos;
                    }
                }
            }
           
        }
    }
    public void Play()
    {
        shake = true;
        firstShake = true;
    }
}
