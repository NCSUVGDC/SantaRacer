using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class SwitchCams : MonoBehaviour
{
    PlayerControls control;
    public Cam1stPerson firstCamera;
    public CameraMovement secondCamera;

    // Start is called before the first frame update
    void Start()
    {
        control = new PlayerControls();
        control.Gameplay.SwitchCams.performed += Switch;
        control.Gameplay.SwitchCams.Enable();

        firstCamera.enabled = true;
        secondCamera.enabled = false;
    }

    void Switch(CallbackContext ctx)
    {
        if (firstCamera.enabled)
        {
            firstCamera.enabled = false;
            secondCamera.enabled = true;
        }
        else
        {
            firstCamera.enabled = true;
            secondCamera.enabled = false;
        }
    }
}
