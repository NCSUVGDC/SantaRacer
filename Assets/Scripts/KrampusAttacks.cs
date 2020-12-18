using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class KrampusAttacks : MonoBehaviour
{
    public Camera krampuscam;
    PlayerControls control;
    public List<GameObject> traps = new List<GameObject>();
    public List<float> waittime = new List<float>();
    List<bool> waiting = new List<bool>();
    int[] current = new int[] { 0, 1, 2 };
    void Start()
    {
        control = new PlayerControls();
        control.Gameplay.KrampusAttack1.performed += Attack1;
        control.Gameplay.KrampusAttack2.performed += Attack2;
        control.Gameplay.KrampusAttack3.performed += Attack3;
        control.Gameplay.KrampusAttack1.Enable();
        control.Gameplay.KrampusAttack2.Enable();
        control.Gameplay.KrampusAttack3.Enable();
        foreach (float time in waittime)
        {
            waiting.Add(false);
        }
    }
    void Attack1(CallbackContext ctx)
    {
        Throw(0);
    }
    void Attack2(CallbackContext ctx)
    {
        Throw(1);
    }
    void Attack3(CallbackContext ctx)
    {
        Throw(2);
    }
    void Throw(int num)
    {
        if (!waiting[current[num]] && traps.Count > current[num])
        {
            GameObject thing = Instantiate(traps[num], transform.position + transform.forward, krampuscam.transform.rotation);
            waiting[current[num]] = true;
            StartCoroutine("wait", current[num]);
        }
    }
    IEnumerator wait(int num)
    {
        yield return new WaitForSeconds(waittime[num]);
        waiting[num] = false;
    }
}
