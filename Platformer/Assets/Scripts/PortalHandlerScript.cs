using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHandlerScript : MonoBehaviour
{
    public GameObject Portal_checker;
    public GameObject Portal_blue;
    public GameObject Portal_Orange;
    public GameObject Blue_Indicator;
    bool Portal_toggle;
    public bool Portal_is_blue;


    private void Update()
    {        
        if(Blue_Indicator.activeInHierarchy == true)
        {
            Portal_is_blue = true;
        }
        else
        {
            Portal_is_blue = false;
        }
       
       

        if(Portal_is_blue==true)
        {
            Portal_Orange.transform.rotation = Portal_blue.transform.rotation;
        }
        if (Portal_is_blue == false)
        {
            Portal_blue.transform.rotation = Portal_Orange.transform.rotation;
        }
    }
}
