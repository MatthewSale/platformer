using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PortalSpawningScript : MonoBehaviour
{
    public GameObject Blue_Indicator;
    public GameObject Orange_Indicator;

    public Transform barral;   

    public GameObject WormHole_Bullet_blue;
    public GameObject WormHole_Bullet_orange;

    public Animator anim;

    GameObject Pause_menu;

    AudioSource Thwump_sound;

    bool anim_toggle=false;

    bool cool_down;

    int cooldown_meater = 100;
    public Slider Cooldown_slider;

    int speed = 1000;

    private void Start()
    {
        Thwump_sound = this.GetComponent<AudioSource>();
        Pause_menu = GameObject.FindGameObjectWithTag("PauseMenu");
    }

    private void Update()
    {
        Cooldown_slider.value = cooldown_meater;
        if (!Pause_menu.activeInHierarchy)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("plese wormhole here?");
                if (cool_down == false)
                {
                    Thwump_sound.Play();
                    if (Blue_Indicator.activeInHierarchy)
                    {
                        GameObject Bullet = Instantiate(WormHole_Bullet_blue, barral.position, barral.rotation) as GameObject;
                        Bullet.transform.Rotate(new Vector3(barral.rotation.x, barral.rotation.y, barral.rotation.z));
                        Rigidbody BulletRigidbody = Bullet.GetComponent<Rigidbody>();
                        BulletRigidbody.AddForce(-transform.right * speed);
                    }
                    else
                    {
                        GameObject Bullet = Instantiate(WormHole_Bullet_orange, barral.position, barral.rotation) as GameObject;
                        Bullet.transform.Rotate(new Vector3(barral.rotation.x, barral.rotation.y, barral.rotation.z));
                        Rigidbody BulletRigidbody = Bullet.GetComponent<Rigidbody>();
                        BulletRigidbody.AddForce(-transform.right * speed);
                    }
                    cool_down = true;
                    cooldown_meater = 0;
                    StartCoroutine(delay());
                    StartCoroutine(delay1());
                }
            }
        }

        if(cooldown_meater >= 100)
        {
            cool_down = false;
        }

       if(Input.GetKeyDown("i"))
       {
            anim.SetBool("blue", anim_toggle);
            anim_toggle = !anim_toggle;
       }
    }    
    IEnumerator delay()
    {
        yield return new WaitForSeconds(5);
          
    }

    IEnumerator delay1()
    {
        yield return new WaitForSeconds(0.033f);
        if(cooldown_meater < 100)
        {
            StartCoroutine(delay1());
        }
        cooldown_meater = cooldown_meater + 1; ;
    }
}
