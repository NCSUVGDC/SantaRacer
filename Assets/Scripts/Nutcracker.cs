using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nutcracker : MonoBehaviour
{
    public GameObject wall;
    GameObject nutcracker = null;
    GameObject nut2 = null;
    GameObject santa;
    [SerializeField] private LayerMask nutcrackerMask;
    public float radius = 5f;
    [SerializeField] private float wallTime;
    private void Awake()
    {
        Find();
    }
    void Find()
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, radius, nutcrackerMask);
        foreach(Collider obj in objects)
        {
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
        GameObject wall = nutcracker.GetComponent<NutcrackerCode>().wall;
        wall.SetActive(true);
        StartCoroutine(WallAlive(wall));
    }
    IEnumerator WallAlive(GameObject wall)
    {
        yield return new WaitForSeconds(wallTime);
        wall.SetActive(false);
        Destroy(gameObject);
    }
}
