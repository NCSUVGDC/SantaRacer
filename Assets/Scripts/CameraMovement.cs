using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class CameraMovement : MonoBehaviour
{
    PlayerControls control;
    public Transform target;
    public float distance = 5.0f;
    public float xSpeed = 30.0f;
    public float ySpeed = 30.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    public float defaultdist = 5.0f;
    public float distanceMin = 1f;
    public float distanceMax;
    public LayerMask player;
    float MouseX;
    float MouseY;
    float x = 0.0f;
    float y = 0.0f;
    Vector3 possiblepos;
    // Use this for initialization
    void Start()
    {
        distanceMax = distance;
        Cursor.visible = false;
        control = new PlayerControls();
        control.Gameplay.CameraRotX.performed += OnRotX;
        control.Gameplay.CameraRotX.canceled += ctx => MouseX = 0;
        control.Gameplay.CameraRotY.performed += OnRotY;
        control.Gameplay.CameraRotY.canceled += ctx => MouseY = 0;
        control.Gameplay.CameraRotX.Enable();
        control.Gameplay.CameraRotY.Enable();
        possiblepos = transform.position;
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
        //target = GameObject.Find("Player").transform;
    }
    void OnRotX(CallbackContext ctx)
    {
        MouseX = ctx.ReadValue<float>();
    }
    void OnRotY(CallbackContext ctx)
    {
        MouseY = ctx.ReadValue<float>();
    }
    void LateUpdate()
    {
        if (target)
        {
            x += MouseX * xSpeed * distance * Time.deltaTime;
            y -= MouseY * ySpeed * Time.deltaTime;
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);

            Vector3 negDistance = new Vector3(0.0f, 0.0f, -defaultdist);
            possiblepos = rotation * negDistance + target.position;
            RaycastHit hit;
            if (Physics.Linecast(target.position, possiblepos, out hit))
            {
                distance = hit.distance;
            }
            else
            {
                distance = defaultdist;
            }
            negDistance = new Vector3(0.0f, 0.0f, -distance);
            Vector3 position = rotation * negDistance + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
