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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sleigh"))
        {
            other.gameObject.GetComponent<Rigidbody>().useGravity = true;
            other.gameObject.GetComponent<PlayerShip>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            StartCoroutine("nograv", other.gameObject);
        }
        else if (other.gameObject.tag != "Krampus")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator nograv(GameObject sleigh)
    {
        yield return new WaitForSeconds(grav);
        sleigh.GetComponent<Rigidbody>().useGravity = false;
        sleigh.gameObject.GetComponent<PlayerShip>().enabled = true;
        Destroy(gameObject);
    }
}
