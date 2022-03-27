using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public Sprite santa;
    public Sprite Krampus;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Awake()
    {
        int win = PlayerPrefs.GetInt("Win");
        if (win == 1)
        {
            GetComponent<Image>().sprite = santa;
            text.text = "Santa Won!";
        }
        else
        {
            GetComponent<Image>().sprite = Krampus;
            text.text = "Krampus Won!";
        }
    }
}
