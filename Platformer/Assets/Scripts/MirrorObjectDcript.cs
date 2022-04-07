using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorObjectDcript : MonoBehaviour
{
    public GameObject Things_to_duplicate;
    GameObject portal_blue;
    GameObject portal_orange;

    GameObject player;

    bool is_blue_Portal;
    bool duplicate;
    bool toggle;

    private void Start()
    {
        portal_blue = GameObject.FindGameObjectWithTag("Portal1");
        portal_orange = GameObject.FindGameObjectWithTag("Portal2");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==("Player"))
        {
           duplicate = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
      //  Destroy(Things_to_duplicate);
        duplicate = false;
    }

    private void Update()
    {
        if (toggle == false)
        {
            if (duplicate == true)
            {
                if (is_blue_Portal == true)
                {
                    Instantiate(Things_to_duplicate, portal_orange.transform.position, player.transform.rotation);
                    //Things_to_duplicate.transform.parent = player;
                    toggle = true;
                }
                else
                {
                    Instantiate(Things_to_duplicate, portal_blue.transform.position, player.transform.rotation);
                    toggle = true;
                }
            }
        }
    }
}
