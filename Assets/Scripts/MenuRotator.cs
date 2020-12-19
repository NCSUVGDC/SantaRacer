using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotator : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.y += speed * Time.deltaTime;
        transform.eulerAngles = rot;
    }
}
