using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Catapult : MonoBehaviour
{
    public bool occupied;
    public float angle = 60;
    public float strength = 1000f;
    PlayerControls control;
    GameObject player;
    bool inRange = false;
    public Camera krampuscamera;
    Vector3 position;
    private void Start()
    {
        occupied = false;
        control = new PlayerControls();
        control.Gameplay.Jump.performed += Launch;
        control.Gameplay.Jump.Enable();
        control.Gameplay.Interact.performed += Enter;
        control.Gameplay.Interact.Enable();
        position = transform.position;
    }
    void Launch(CallbackContext ctx)
    {
        if (occupied)
        {
            occupied = false;
            var dir = Quaternion.AngleAxis(angle, transform.right) * transform.forward;
            player.GetComponent<Rigidbody>().AddForce(dir * -strength);
            player.GetComponent<KrampusMovement>().canjump = true;
            player.GetComponent<KrampusMovement>().movable = true;
            //krampuscamera.GetComponent<Cam1stPerson>().inCatapult = false;
        }
    }
    void Enter(CallbackContext ctx)
    {
        if (inRange)
        {
            Vector3 newpos = transform.position;
            newpos.y += 2;
            player.transform.position = newpos;
            occupied = true;
            player.GetComponent<KrampusMovement>().movable = false;
            player.GetComponent<KrampusMovement>().canjump = false;
            //krampuscamera.GetComponent<Cam1stPerson>().inCatapult = true;
            //krampuscamera.GetComponent<Cam1stPerson>().catapult = transform;
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
