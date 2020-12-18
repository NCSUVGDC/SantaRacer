using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class SantaTraps : MonoBehaviour
{
    PlayerControls control;
    public List<GameObject> traps = new List<GameObject>();
    public List<float> waittime = new List<float>();
    List<bool> waiting = new List<bool>();
    int current = 0;
    private void Start()
    {
        control = new PlayerControls();
        control.Gameplay.SantaTrap.performed += SantaTrap;
        control.Gameplay.SantaTrap.Enable();
        control.Gameplay.CycleTrapsR.performed += CycleRight;
        control.Gameplay.CycleTrapsL.performed += CycleLeft;
        control.Gameplay.CycleTrapsL.Enable();
        control.Gameplay.CycleTrapsR.Enable();
        foreach (float time in waittime)
        {
            waiting.Add(false);
        }
    }
    void SantaTrap(CallbackContext ctx)
    {
        if (!waiting[current])
        {
            Vector3 newpos = transform.position;
            newpos.y -= 2;
            GameObject drop = GameObject.Instantiate(traps[current]);
            drop.transform.position = newpos;
            waiting[current] = true;
            StartCoroutine("wait", current);
        }
    }
    void CycleRight(CallbackContext ctx)
    {
        if (current == traps.Count - 1)
        {
            current = 0;
        }
        else
            current++;
    }
    void CycleLeft(CallbackContext ctx)
    {
        if (current == 0)
        {
            current = traps.Count - 1;
        }
        else
            current--;
    }
    IEnumerator wait(int num)
    {
        yield return new WaitForSeconds(waittime[num]);
        waiting[num] = false;
    }
}
