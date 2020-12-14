using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimney : MonoBehaviour
{
    // Start is called before the first frame update
    public float staytime = 3.0f;
    float timeelapsed = 0f;
    public Material green;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        timeelapsed = 0f;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Sleigh")
        {
            if (timeelapsed < staytime && Input.GetKey(KeyCode.Q))
            {
                timeelapsed += Time.deltaTime;
            }
            else if (timeelapsed >= staytime)
            {
                gameObject.GetComponent<MeshRenderer>().material = green;
                gameObject.GetComponent<SphereCollider>().enabled = false;
            }
        }
    }
}
