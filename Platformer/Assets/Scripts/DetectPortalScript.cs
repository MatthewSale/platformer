using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPortalScript : MonoBehaviour
{
    public GameObject Audio_Checker;
    bool used;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Portal1"))
        {
            if (used == false)
            {
                Audio_Checker.SetActive(true);
                used = true;
            }
        }

        if (other.tag == ("Portal2"))
        {
            if (used == false)
            {
                Audio_Checker.SetActive(true);
                used = true;
            }
        }
    }
}
