using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundActivationArea : MonoBehaviour
{
    public GameObject Audio_Checker;
    bool used;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==("Player"))
        {
            if (used == false)
            {
                Audio_Checker.SetActive(true);
                used = true;
            }
        }
    }
}
