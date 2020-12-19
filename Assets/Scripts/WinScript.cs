using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    public Material santa;
    public Material Krampus;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Awake()
    {
        int win = PlayerPrefs.GetInt("Win");
        if (win == 1)
        {
            gameObject.GetComponent<Renderer>().material = santa;
            text.text = "Santa Won!";
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = Krampus;
            text.text = "Krampus Won!";
        }
    }
}
