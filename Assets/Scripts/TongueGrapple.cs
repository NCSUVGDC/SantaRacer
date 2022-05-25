using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class TongueGrapple : MonoBehaviour
{
    public float maxdist = 30f;
    GameObject player=null;
    Vector3 finalpos;
    public float strength = 1f;
    public float seconds = 3.0f;
    bool pulling = false;
    Vector3 lastPos;
    void Start()
    {
        Grab();
    }
    void Grab()
    {
        Vector3 line = maxdist * transform.forward;
        RaycastHit hit;
        float distance = 0;
        if (Physics.Linecast(transform.position, transform.position + line, out hit))
        {
            if (hit.transform.gameObject.tag != "Sleigh")
            {
                distance += hit.distance;
                finalpos = hit.point;
                Pull(distance);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Pull(float distance)
    {
        Vector3 linedist = distance * transform.forward;
        transform.position = (transform.position + linedist + transform.position) / 2;
        Vector3 newScale = transform.localScale;
        newScale.z = distance;
        transform.localScale = newScale;
        player = GameObject.FindGameObjectWithTag("Krampus");
        player.GetComponent<KrampusMovement>().movable = false;
        player.GetComponent<KrampusMovement>().canjump = false;
        player.GetComponent<Rigidbody>().useGravity = false;
        if (Vector3.Distance(finalpos,transform.position)<5)
        {
            strength = 3;
        }
        player.GetComponent<Rigidbody>().AddForce((finalpos - transform.position) * Vector3.Distance(transform.position, finalpos) * strength, ForceMode.Impulse);
        pulling = true;
    }
    private void FixedUpdate()
    {
        if (pulling)
        {
            if (Vector3.Distance(player.transform.position,finalpos) <= 1.5 || CalculateDistance())
            {
                player.GetComponent<KrampusMovement>().movable = true;
                player.GetComponent<KrampusMovement>().canjump = true;
                player.GetComponent<Rigidbody>().useGravity = true;
                Destroy(gameObject);
            }
            lastPos = player.transform.position;
        }
    }

    private bool CalculateDistance()
    {
        if (lastPos == null)
        {
            return false;
        }
        if (Vector3.Magnitude(player.transform.position - lastPos) < 0.01)
        {
            return true;
        }
        return false;
    }
}
