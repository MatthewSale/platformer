using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGiveWormHoleCannonScript : MonoBehaviour
{
    public GameObject Press_E_object;   
    bool cooldown;
    GameObject WormHole_Cannon;
    public GameObject cannon_object;
    AudioSource sound;
    public GameObject pedistool;

    private void Start()
    {
        Press_E_object.SetActive(false);
        sound = this.GetComponent<AudioSource>();
        WormHole_Cannon = GameObject.FindGameObjectWithTag("Wormhole cannon");
        WormHole_Cannon.SetActive(false);
        pedistool.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Press_E_object.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (cooldown == false)
        {
            if (Input.GetKeyUp("e"))
            {
                cooldown = true;               
                sound.Play();
                WormHole_Cannon.SetActive(true);
                cannon_object.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == ("Player"))
        {
            Press_E_object.SetActive(false);
        }
    }
}
