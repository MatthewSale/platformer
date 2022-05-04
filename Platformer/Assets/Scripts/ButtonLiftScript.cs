using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLiftScript : MonoBehaviour
{
    public GameObject Press_E_object;
    public Animator anim;
    bool cooldown;
    public Animator Lift;
    AudioSource sound;
    bool toggle;

    private void Start()
    {
        Press_E_object.SetActive(false);
        sound = this.GetComponent<AudioSource>();
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

                if (toggle == false)
                {
                    Lift.SetBool("Lift", true);
                    toggle = true;
                }
                else
                {
                    Lift.SetBool("Lift", false);
                    toggle = false;
                }
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
