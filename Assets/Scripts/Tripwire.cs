using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripwire : MonoBehaviour
{
    public float yrot = 0;
    public float wireheight = .6f;
    public float width = .25f;
    public float maxlength = 30f;
    public float time = 20f;
    bool initialhit = true;
    public float waittime = 5f;
    GameObject player;
    bool incontact = false;
    private void Awake()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.x = 0;
        rotation.z = 0;
        rotation.y = 0;
        transform.eulerAngles = rotation;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Sleigh" && initialhit)
        {
            initialhit = false;
            Expand();
        }
        else if (initialhit)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Krampus")
        {
            incontact = true;
            player = collision.gameObject;
            player.GetComponent<KrampusMovement>().movable = false;
            player.GetComponent<KrampusMovement>().canjump = false;
            StartCoroutine("impair");
        }
    }
    void Expand()
    {
        Destroy(GetComponent<Rigidbody>());
        Vector3 newpos = transform.position;
        newpos.y = wireheight;
        transform.position = newpos;
        Rotation();
        Vector3 direction = maxlength * transform.forward;
        RaycastHit hit;
        float length = 0;
        Vector3 hit1 = Vector3.zero;
        Vector3 hit2 = Vector3.zero;
        if (Physics.Raycast(transform.position, direction, out hit))
        {
            hit1 = hit.point;
            length += hit.distance;
        }
        else
        {
            Destroy(gameObject);
        }
        if (Physics.Raycast(transform.position, -direction, out hit))
        {
            hit2 = hit.point;
            length += hit.distance;
        }
        else
        {
            Destroy(gameObject);
        }
        newpos.z = (hit1.z + hit2.z) / 2;
        newpos.x = (hit1.x + hit2.x) / 2;
        transform.position = newpos;
        Vector3 scale = transform.localScale;
        scale.z = length;
        transform.localScale = scale;
        StartCoroutine("destroyer");
    }
    void Rotation()
    {
        float lengthF = 0;
        float lengthR = 0;
        Vector3 direction = maxlength * transform.forward;
        RaycastHit hit;
        if (Physics.Linecast(transform.position, transform.position+direction, out hit))
        {
            lengthF += hit.distance;
        }
        else
        {
            lengthF += maxlength;
        }
        if (Physics.Linecast(transform.position, transform.position -direction, out hit))
        {
            lengthF += hit.distance;
        }
        else
        {
            lengthF += maxlength;
        }
        direction = maxlength * transform.right;
        if (Physics.Linecast(transform.position, transform.position + direction, out hit))
        {
            lengthR += hit.distance;
        }
        else
        {
            lengthR += maxlength;
        }
        if (Physics.Linecast(transform.position, transform.position - direction, out hit))
        {
            lengthR += hit.distance;
        }
        else
        {
            lengthR += maxlength;
        }
        if (lengthR < lengthF)
        {
            Vector3 rotation = transform.eulerAngles;
            rotation.y += 90;
            transform.eulerAngles = rotation;
        }
    }
    IEnumerator destroyer()
    {
        yield return new WaitForSeconds(time);
        if (incontact)
        {
            player.GetComponent<KrampusMovement>().movable = true;
            player.GetComponent<KrampusMovement>().canjump = true;
        }
        Destroy(gameObject);
    }
    IEnumerator impair()
    {
        yield return new WaitForSeconds(waittime);
        player.GetComponent<KrampusMovement>().movable = true;
        player.GetComponent<KrampusMovement>().canjump = true;
        Destroy(gameObject);
    }
}
