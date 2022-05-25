using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerShip : MonoBehaviour
{
    PlayerControls controls;

    public GameObject ship;

    public float speed = 5;
    public float maxSpeed = 15;
    public float minSpeed = 1;
    

    //public float speedSpinBoundary = 0.5f;

    public float speedSensitivity = 1;
    public float spinSensitivity = 1;
    public float turnSensitivity = 1;

    public float lateralFriction = 20f;
    public float verticalFriction = 20f;

    private float changeInSpeed;
    private float changeInSpin;
    private Vector2 changeInTurn;

    //public float turnVal;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Gameplay.Speed.performed += ctx => changeInSpeed = ctx.ReadValue<Vector2>().y;
        controls.Gameplay.Speed.canceled += ctx => changeInSpeed = 0;
        controls.Gameplay.Speed.Enable();

        controls.Gameplay.Spin.performed += ctx => changeInSpin = ctx.ReadValue<Vector2>().x;   // I'll try spinning,
        controls.Gameplay.Spin.canceled += ctx => changeInSpin = 0;                             // that's a good trick!
        controls.Gameplay.Spin.Enable();

        controls.Gameplay.Turn.performed += ctx => changeInTurn = ctx.ReadValue<Vector2>();
        controls.Gameplay.Turn.canceled += ctx => changeInTurn = Vector2.zero;
        controls.Gameplay.Turn.Enable();

    }

    void ChangeSpeed(float speedChange)
    {
        speedChange /= 3;
        speedChange *= speedSensitivity;

        if (speed + speedChange >= maxSpeed)
        {
            speed = maxSpeed;
            
        }
        else if (speed + speedChange <= minSpeed)
        {
            speed = minSpeed;
        }
        else
        {
            speed += speedChange;
        }
    }

    void ChangeSpin(float spinChange)
    {
        //if (changeInSpeed < speedSpinBoundary && changeInSpeed > -speedSpinBoundary)
        {
            spinChange *= spinSensitivity;

            gameObject.transform.Rotate(new Vector3(0, 0, -spinChange));
        }
    }

    void ChangeTurn(Vector2 turnChange)
    {
        turnChange *= turnSensitivity;
        gameObject.transform.Rotate(new Vector3(-turnChange.y, turnChange.x, 0));
    }

    private void FixedUpdate()
    {
        ChangeSpeed(changeInSpeed);
        ChangeSpin(changeInSpin);
        ChangeTurn(changeInTurn);
        //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(5, 5, 5);

        if (true)
        {
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        }
        //else
        //{
        //    gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        //}

        // Praise be to Alberto Carrillo for helping with physics
        LateralFriction();
        VerticalFriction();
    }

    private void LateralFriction()
    {
        Rigidbody m_body = gameObject.GetComponent<Rigidbody>();

        // faked lateral friction to limit sliding behavior
        float lateralVelocty = Vector3.Dot(m_body.velocity, transform.right);

        // calculate lateral friction force based on lateral velocity squared and the correction factors.
        Vector3 lateralFrictionForce = -transform.right * Mathf.Sign(lateralVelocty) * lateralVelocty * lateralVelocty * lateralFriction * Time.deltaTime * m_body.mass;

        m_body.AddForce(lateralFrictionForce);
        Debug.DrawRay(transform.position, lateralFrictionForce / 1000f);
    }

    private void VerticalFriction()
    {
        Rigidbody m_body = gameObject.GetComponent<Rigidbody>();

        // faked vertical friction to limit sliding behavior
        float verticalVelocity = Vector3.Dot(m_body.velocity, transform.up);

        // calculate vertical friction force based on vertical velocity squared and the correction factors.
        Vector3 verticalFrictionForce = -transform.right * Mathf.Sign(verticalVelocity) * verticalVelocity * verticalVelocity * verticalFriction * Time.deltaTime * m_body.mass;

        m_body.AddForce(verticalFrictionForce);
        Debug.DrawRay(transform.position, verticalFrictionForce / 1000f);
    }

}
