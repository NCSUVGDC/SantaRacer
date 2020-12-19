using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimneyCount : MonoBehaviour
{
    public float used = 0;
    float chimneycount;
    // Start is called before the first frame update
    void Start()
    {
        Chimney[] children = GetComponentsInChildren<Chimney>();
        chimneycount = children.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (used==chimneycount)
        {
            //end game
        }
    }
}
