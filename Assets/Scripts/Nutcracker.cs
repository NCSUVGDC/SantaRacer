using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nutcracker : MonoBehaviour
{
    public GameObject wall;
    GameObject nutcracker = null;
    GameObject nut2 = null;
    GameObject santa;
    public float radius = 5f;
    private void Awake()
    {
        Find();
    }
    void Find()
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider obj in objects)
        {
            Debug.Log(obj.gameObject.tag);
            if (obj.gameObject.tag == "nutcracker")
            {
                nutcracker = obj.gameObject;
                nut2 = nutcracker.GetComponent<NutcrackerCode>().nutcracker2;
                break;
            }
        }
        if (nutcracker == null || nut2 == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Wall();
        }
    }
    void Wall()
    {
        Vector3 pos = (nutcracker.transform.position + nut2.transform.position) / 2;
        float dist = Vector3.Distance(nutcracker.transform.position, nut2.transform.position);
        Transform walltransform = wall.transform;
        Vector3 scale = wall.transform.localScale;
        scale.x = dist;
        walltransform.position = pos;
        walltransform.localScale = scale;
        GameObject spawnedwall = Instantiate(wall, walltransform);
        spawnedwall.transform.forward = nutcracker.transform.right;
    }
}
