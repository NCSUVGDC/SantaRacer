using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Cam1stPerson : MonoBehaviour
{
    public Rigidbody krampus;
    PlayerControls control;
    public float xSensitivity = 120f;
    public float ySensitivity = 120f;
    public float yMin = -45;
    public float yMax = 90;
    float MouseX = 0;
    float MouseY = 0;
    float x = 0f;
    float y = 0f;
    public float distance = 4f;
    public Transform catapult;
    public bool inCatapult = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        control = new PlayerControls();
        control.Gameplay.CameraRotX.performed += OnRotX;
        control.Gameplay.CameraRotX.canceled += ctx => MouseX = 0;
        control.Gameplay.CameraRotY.performed += OnRotY;
        control.Gameplay.CameraRotY.canceled += ctx => MouseY = 0;
        control.Gameplay.CameraRotX.Enable();
        control.Gameplay.CameraRotY.Enable();
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }
    void OnRotX(CallbackContext ctx)
    {
        MouseX = ctx.ReadValue<float>();
    }
    void OnRotY(CallbackContext ctx)
    {
        MouseY = ctx.ReadValue<float>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        x += MouseX * xSensitivity * Time.deltaTime;
        y -= MouseY * xSensitivity * Time.deltaTime;
        y = ClampAngle(y, yMin, yMax);
        Quaternion rotation = Quaternion.Euler(y, x, 0);
        transform.rotation = rotation;
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
