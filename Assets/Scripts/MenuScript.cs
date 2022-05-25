using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    TextMeshProUGUI tmp;
    PlayerControls control;
    public bool chosen = false;
    Color red;
    Color black;
    public MenuScript other;
    void Start()
    {
        red = new Color(145, 31, 31);
        black = new Color(0, 0, 0, 255);
        tmp = GetComponent<TextMeshProUGUI>();
        control = new PlayerControls();
        control.Menu.Choose.performed += Select;
        control.Menu.Change.performed += Change;
        control.Menu.Change.Enable();
        control.Menu.Choose.Enable();
        if (!chosen)
        {
            tmp.faceColor = black;
        }
    }
    void Change(CallbackContext ctx)
    {
        if (chosen)
        {
            chosen = false;
            tmp.faceColor = black;
        }
        else
        {
            chosen = true;
            tmp.faceColor = red;
        }
    }
    void Select(CallbackContext ctx)
    {
        if (chosen && tmp.text.Equals("Start") || tmp.text.Equals("Replay"))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Application.Quit();
        }
    }
    private void OnDestroy()
    {
        control.Disable();
    }
}
