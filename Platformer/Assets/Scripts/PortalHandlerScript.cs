using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalHandlerScript : MonoBehaviour
{
    public GameObject Portal_checker;
    public GameObject Portal_blue;
    public GameObject Portal_Orange;
    bool Portal_toggle;
    public bool Portal_is_blue;

    private void Update()
    {
        //checks what portal is currently active / last shot.
        if (Portal_checker == null)
        {
            if (Portal_toggle == false)
            {
                Portal_checker = GameObject.FindGameObjectWithTag("Blue_Indicator_visial");
                Portal_toggle = true;
                Portal_is_blue = true;
            }
            else
            {
                Portal_checker = GameObject.FindGameObjectWithTag("Orange_Indicator_visial");
                Portal_toggle = false;
                Portal_is_blue = false;
            }
        }        
        if(!Portal_checker.activeInHierarchy)
        {
            Portal_checker = null;           
        }
        //checks what portal is currently active / last shot.

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
