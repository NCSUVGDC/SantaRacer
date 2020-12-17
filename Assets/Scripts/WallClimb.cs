using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class WallClimb : MonoBehaviour
{
    PlayerControls control;
    public float speed = 1f;
    Vector2 direction;
    private void Start()
    {
        control = new PlayerControls();
        control.Gameplay.KrampusMove.performed += Direction;
        control.Gameplay.KrampusMove.Enable();
    }
    void Direction(CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Krampus" && direction[1] == 1)
        {
            float size = GetComponent<Collider>().bounds.extents.y;
            float krampussize = collision.gameObject.GetComponent<Collider>().bounds.extents.y;
            if (collision.transform.position.y-krampussize < transform.position.y+size)
            {
                collision.gameObject.GetComponent<Rigidbody>().position += new Vector3(0, speed, 0);
            }
        }
    }
}
