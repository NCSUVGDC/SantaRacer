using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour
{
    public Transform landing;
    public float strength = 0.1f;
    public bool teleport = false;
    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Krampus")
        {
            float size = collision.gameObject.GetComponent<Collider>().bounds.extents.y;
            if (collision.transform.position.y - size > transform.position.y)
            {
                if (teleport)
                    Teleport(collision.gameObject, size);
                else
                    Launch(collision.gameObject, size);
            }
        }
    }
    void Launch(GameObject collider, float size)
    {
        Vector3 final = new Vector3((landing.position.x+transform.position.x)/2, landing.position.y + size+1, landing.position.z);
        collider.GetComponent<Rigidbody>().AddForce((final - transform.position) * Vector3.Distance(transform.position, final)*strength, ForceMode.Impulse);
    }
    void Teleport(GameObject collider, float size)
    {
        Vector3 newpos = new Vector3(landing.position.x, landing.position.y + size, landing.position.z);
        collider.transform.position = newpos;
    }
}
