using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackintheBox : MonoBehaviour
{
    public float strength = 100f;
    public float blastradius = 5f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Krampus");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, blastradius);
        foreach(Collider thing in objects)
        {
            Rigidbody rb = thing.GetComponent<Rigidbody>();
            if (rb != null && thing.gameObject.tag=="Krampus")
                rb.AddExplosionForce(strength, transform.position, blastradius, 3.0f, ForceMode.Impulse);
        }
        Destroy(gameObject);
    }
}
