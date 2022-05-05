using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class ButtonTurnOffScript : MonoBehaviour
{
    public GameObject Press_E_object;
    public Animator anim;
    bool cooldown;
    public GameObject portal_bullet_Blue;
    public GameObject portal_bullet_Orange;
    public Transform bullet_spawn_location;
    public Transform bullet_spawn_location_secondary;
    AudioSource sound;
    public GameObject checker_ob;
    bool used;

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
                Instantiate(portal_bullet_Blue, bullet_spawn_location.position, Quaternion.identity);
                Instantiate(portal_bullet_Orange, bullet_spawn_location_secondary.position, Quaternion.identity);
                sound.Play();
                if (used == false)
                {
                    checker_ob.SetActive(true);
                    used = true;
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
