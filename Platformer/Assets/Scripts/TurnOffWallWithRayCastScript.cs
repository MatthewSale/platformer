using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffWallWithRayCastScript : MonoBehaviour
{
    GameObject wall;
    public bool is_orange;
    
    private void OnTriggerEnter(Collider other)
    {
        wall = other.gameObject;
        if (is_orange == true)
        {
            wall.layer = 6;
        }
        else
        {
            wall.layer = 7;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        wall = other.gameObject;
        wall.layer = 0;
    }
}
