using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class ChildThrow : MonoBehaviour
{
    PlayerControls control;
    public GameObject child;
    public float speed = 5.0f;
    public Camera krampuscamera;
    bool throwable = true;
    public float waittime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        control = new PlayerControls();
        control.Gameplay.ChildThrow.performed += ThrowtheChild;
        control.Gameplay.ChildThrow.Enable();
    }
    void ThrowtheChild(CallbackContext ctx)
    {
        if (throwable)
        {
            GameObject ThrownChild = GameObject.Instantiate(child, transform.position+krampuscamera.transform.forward, transform.rotation);
            ThrownChild.GetComponent<Rigidbody>().velocity = krampuscamera.transform.forward * speed;
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        throwable = false;
        yield return new WaitForSeconds(4);
        throwable = true;
        Debug.Log("throwable");
    }
}
