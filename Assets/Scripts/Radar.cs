using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radar : MonoBehaviour
{
    // Santa Position
    public Transform santa;
    // Krampus Position
    public Transform krampus;
    // Angle (0 - 359) to Santa
    public float angle;
    // Enum for directions
    enum Direction { North, Northeast, East, Southeast, South, Southwest, West, Northwest}
    Direction output;
    // UI
    public Image North;
    public Image Northeast;
    public Image East;
    public Image Southeast;
    public Image South;
    public Image Southwest;
    public Image West;
    public Image Northwest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //angle = Vector3.Angle(santa.position, krampus.position);
        float delta_x = krampus.position.x - santa.position.x;
        float delta_z = krampus.position.z - santa.position.z;
        angle = Mathf.Atan2(delta_z, delta_x);
        angle = Mathf.Rad2Deg * angle;
        angle = angle + 180;
        Debug.Log(angle);
        output = CalculateDirection(angle);
        switch (output)
        {
            case Direction.North:
                North.enabled = true;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.Northeast:
                North.enabled = false;
                Northeast.enabled = true;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.East:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = true;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.Southeast:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = true;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.South:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = true;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.Southwest:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = true;
                West.enabled = false;
                Northwest.enabled = false;
                break;
            case Direction.West:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = true;
                Northwest.enabled = false;
                break;
            case Direction.Northwest:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = true;
                break;
            default:
                North.enabled = false;
                Northeast.enabled = false;
                East.enabled = false;
                Southeast.enabled = false;
                South.enabled = false;
                Southwest.enabled = false;
                West.enabled = false;
                Northwest.enabled = false;
                break;
        }
        
    }

    Direction CalculateDirection(float angle)
    {
        if (angle >= 60 && angle < 120)
        {
            return Direction.North;
        }
        else if (angle >= 120 && angle < 150)
        {
            return Direction.Northwest;
        }
        else if (angle >= 150 && angle < 210)
        {
            return Direction.West;
        }
        else if (angle >= 210 && angle < 240)
        {
            return Direction.Southwest;
        }
        else if (angle >= 240 && angle < 300)
        {
            return Direction.South;
        }
        else if (angle >= 300 && angle < 330)
        {
            return Direction.Southeast;
        }
        else if (angle >= 330 && angle < 359 || angle >= 0 && angle < 30)
        {
            return Direction.East;
        }
        else
        {
            return Direction.Northeast;
        }
    }
}
