using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class KrampusMovement : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody player;
    PlayerControls control;
    float forward = 0;
    float sideways = 0;
    Vector2 direction;
    float distancetoGround;
    public float jumpspeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        distancetoGround = GetComponent<Collider>().bounds.extents.y;
        control = new PlayerControls();
        control.Gameplay.KrampusMove.performed += Direction;
        control.Gameplay.KrampusMove.canceled += ctx => direction = new Vector2(0,0);
        control.Gameplay.Jump.performed += Jump;
        control.Gameplay.Jump.Enable();
        control.Gameplay.KrampusMove.Enable();
        player = GetComponent<Rigidbody>();
    }
    void Jump(CallbackContext ctx)
    {
        if (Grounded())
        {
            player.velocity = new Vector3(player.velocity.x, jumpspeed, player.velocity.z);
        }
    }
    void Direction(CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, transform.eulerAngles.z);
        player.position += transform.forward * direction[1] * speed * Time.deltaTime;
        player.position += transform.right * direction[0] * speed * Time.deltaTime;
    }
    bool Grounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distancetoGround + .1f);
    }
}
