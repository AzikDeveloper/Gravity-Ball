using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public Transform Scene;
    public Rigidbody ball;
    public Button RightButton;
    public Button LeftButton;
    public Text attempsText;
    public float rotSpeed = 750f;
    bool rotate_to_right = false;
    bool rotate_to_left = false;
    bool isRunningRight =  false;
    bool isRunningLeft = false;
    float rotation = 0f;
    float exactRot = 0f;
    float attemps;

    private void Start()
    {
        Button rb = RightButton.GetComponent<Button>();
        Button lb = LeftButton.GetComponent<Button>();
        rb.onClick.AddListener(toRight);
        lb.onClick.AddListener(toLeft);
    }
       
    private void Update()
    {
        
        if (rotate_to_left && !isRunningRight)
        {
            FreezeBall();
            isRunningLeft = true;
            rotation += Time.deltaTime * rotSpeed;
            Scene.Rotate(-Time.deltaTime * rotSpeed, 0f, 0f);
            if (rotation >= 90f)
            {
                exactRot -= 90;
                Scene.rotation = Quaternion.Euler(exactRot, 0f, 0f);
                UnFreezeBall();
                rotation = 0f;
                rotate_to_left = false;
                isRunningLeft = false;
            }
        }
        if (rotate_to_right && !isRunningLeft)
        {
            FreezeBall();
            isRunningRight = true;
            rotation += Time.deltaTime * rotSpeed;
            Scene.Rotate(Time.deltaTime * rotSpeed, 0f, 0f);
            if (rotation >= 90f)
            {
                exactRot += 90;
                Scene.rotation = Quaternion.Euler(exactRot, 0f, 0f);
                UnFreezeBall();
                rotation = 0f;
                rotate_to_right = false;
                isRunningRight = false;
            }
        }
    }
    void toRight()
    {
        if (!isRunningLeft && !isRunningRight)
        {
            attemps++;
            attempsText.text = attemps.ToString();
            rotate_to_right = true;
        }

    }
    void toLeft()
    {
        if(!isRunningLeft && !isRunningRight) 
        {
            attemps++;
            attempsText.text = attemps.ToString();
            rotate_to_left = true;

        }
    }
    void FreezeBall()
    {   /*
        ball.constraints = RigidbodyConstraints.FreezePositionX;
        ball.constraints = RigidbodyConstraints.FreezePositionY;
        */
    }
    void UnFreezeBall()
    {
        /*
        ball.constraints = RigidbodyConstraints.None;
        ball.constraints = RigidbodyConstraints.None;
        */
    }

}
