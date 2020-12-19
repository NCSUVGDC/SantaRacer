using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    public float speed = 5.0f;
    public float grav = 3f;
    private void Awake()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sleigh")
        {
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            StartCoroutine("nograv", collision.gameObject);
        }
        else if (collision.gameObject.tag != "Krampus")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator nograv(GameObject sleigh)
    {
        yield return new WaitForSeconds(grav);
        sleigh.GetComponent<Rigidbody>().useGravity = false;
        Destroy(gameObject);
    }
}
