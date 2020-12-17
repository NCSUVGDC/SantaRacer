using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Catapult : MonoBehaviour
{
    public bool occupied = false;
    public float angle = 45;
    public float strength = 10f;
    PlayerControls control;
    GameObject player;
    bool inRange = false;
    public Camera krampuscamera;
    private void Start()
    {
        control = new PlayerControls();
        control.Gameplay.Jump.performed += Launch;
        control.Gameplay.Jump.Enable();
        control.Gameplay.Interact.performed += Enter;
        control.Gameplay.Interact.Enable();
    }
    void Launch(CallbackContext ctx)
    {
        if (occupied)
        {
            var dir = Quaternion.AngleAxis(angle, transform.right) * transform.forward;
            player.GetComponent<Rigidbody>().AddForce(dir * -strength);
            player.transform.parent = null;
            player.GetComponent<KrampusMovement>().canjump = true;
            player.GetComponent<KrampusMovement>().movable = true;
            krampuscamera.GetComponent<CameraMovement>().incatapult = false;
        }
    }
    void Enter(CallbackContext ctx)
    {
        if (inRange)
        {
            player.transform.position = transform.position;
            occupied = true;
            player.transform.forward = -transform.forward;
            player.transform.SetParent(transform);
            player.GetComponent<KrampusMovement>().movable = false;
            player.GetComponent<KrampusMovement>().canjump = false;
            krampuscamera.GetComponent<CameraMovement>().incatapult = true;
            krampuscamera.GetComponent<CameraMovement>().catapult = gameObject;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Krampus")
        {
            inRange = true;
            player = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Krampus")
        {
            inRange = false;
            player = other.gameObject;
        }
    }
}
