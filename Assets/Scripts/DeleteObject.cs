using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public float speed = 5.0f;
    private void Awake()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Krampus")
        {
            Destroy(gameObject);
        }
    }
}
