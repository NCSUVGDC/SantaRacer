using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Chimney : MonoBehaviour
{
    // Start is called before the first frame update
    public float staytime = 3.0f;
    float timeelapsed = 0f;
    public Material green;
    PlayerControls controls;
    bool pressed = false;
    private void Awake()
    { 
        controls = new PlayerControls();
        controls.Gameplay.ChimneyUse.performed += OnPress;
        controls.Gameplay.ChimneyUse.canceled += OnRelease;
        controls.Gameplay.ChimneyUse.Enable();
    }
    void OnPress(CallbackContext ctx)
    {
        pressed = true;
    }
    void OnRelease(CallbackContext ctx)
    {
        pressed = false;
        timeelapsed = 0f;
    }
    private void OnTriggerExit(Collider other)
    {
        timeelapsed = 0f;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Sleigh")
        {
            if (timeelapsed < staytime && pressed)
            {
                timeelapsed += Time.deltaTime;
            }
            else if (timeelapsed >= staytime)
            {
                gameObject.GetComponent<MeshRenderer>().material = green;
                gameObject.GetComponent<SphereCollider>().enabled = false;
            }
        }
    }
}
