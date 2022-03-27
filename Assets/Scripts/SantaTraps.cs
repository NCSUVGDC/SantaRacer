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
    int[] current = new int[] { 0, 1, 2 };
    private void Start()
    {
        control = new PlayerControls();
        control.Gameplay.SantaTrapW.performed += SantaTrapW;
        control.Gameplay.SantaTrapW.Enable();
        control.Gameplay.SantaTrapN.performed += SantaTrapN;
        control.Gameplay.SantaTrapN.Enable();
        control.Gameplay.SantaTrapE.performed += SantaTrapS;
        control.Gameplay.SantaTrapE.Enable();
        control.Gameplay.CycleTrapsR.performed += CycleRight;
        control.Gameplay.CycleTrapsL.performed += CycleLeft;
        control.Gameplay.CycleTrapsL.Enable();
        control.Gameplay.CycleTrapsR.Enable();
        foreach (float time in waittime)
        {
            waiting.Add(false);
        }
    }
    void SantaTrapW(CallbackContext ctx)
    {
        if (!waiting[current[0]] && traps.Count > current[0])
        {
            Vector3 newpos = transform.position;
            newpos.y -= 2;
            GameObject drop = GameObject.Instantiate(traps[current[0]]);
            drop.transform.position = newpos;
            waiting[current[0]] = true;
            StartCoroutine("wait", current[0]);
        }
    }
    void SantaTrapN(CallbackContext ctx)
    {
        if (!waiting[current[1]] && traps.Count > current[1])
        {
            Vector3 newpos = transform.position;
            newpos.y -= 2;
            GameObject drop = GameObject.Instantiate(traps[current[1]]);
            drop.transform.position = newpos;
            waiting[current[1]] = true;
            StartCoroutine("wait", current[1]);
        }
    }
    void SantaTrapS(CallbackContext ctx)
    {
        if (!waiting[current[2]] && traps.Count > current[2])
        {
            Vector3 newpos = transform.position;
            newpos.y -= 2;
            GameObject drop = GameObject.Instantiate(traps[current[2]], transform);
            waiting[current[2]] = true;
            StartCoroutine("wait", current[2]);
        }
    }
    void CycleRight(CallbackContext ctx)
    {
        for(int i =0; i < current.Length;i++)
        {
            if (current[i] >= traps.Count - 1)
            {
                current[i] = 0;
            }
            else
                current[i]++;
        }
    }
    void CycleLeft(CallbackContext ctx)
    {
        for (int i = 0; i < current.Length;i++)
        {
            if (current[i] <= 0)
            {
                current[i] = traps.Count - 1;
            }
            else
                current[i]--;
        }
    }
    IEnumerator wait(int num)
    {
        yield return new WaitForSeconds(waittime[num]);
        waiting[num] = false;
    }
}
