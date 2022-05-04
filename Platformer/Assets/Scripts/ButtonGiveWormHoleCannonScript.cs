using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGiveWormHoleCannonScript : MonoBehaviour
{
    public GameObject Press_E_object;
    public Animator anim;
    bool cooldown;
    GameObject WormHole_Cannon;
    AudioSource sound;

    private void Start()
    {

        Press_E_object.SetActive(false);
        sound = this.GetComponent<AudioSource>();
        WormHole_Cannon = GameObject.FindGameObjectWithTag("Wormhole cannon");
        WormHole_Cannon.SetActive(false);
     
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
                anim.SetBool("Pressed", true);
                StartCoroutine(Delay());
                cooldown = true;               
                sound.Play();
                WormHole_Cannon.SetActive(true);
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


    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("Pressed", false);
        cooldown = false;
    }
}
