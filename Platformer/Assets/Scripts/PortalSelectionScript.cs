using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSelectionScript : MonoBehaviour
{
    public GameObject Portal_Indicator_orange;
    public GameObject Portal_Indicator_blue;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("OrangeIndicator"))
        {
            Portal_Indicator_orange.SetActive(true);
            Portal_Indicator_blue.SetActive(false);
        }

        if (other.tag == ("BlueIndicator"))
        {
            Portal_Indicator_orange.SetActive(false);
            Portal_Indicator_blue.SetActive(true);
        }
    }
}
