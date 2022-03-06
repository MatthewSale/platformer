using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawningScript : MonoBehaviour
{
    public GameObject Blue_Indicator;
    public GameObject Orange_Indicator;

    public Transform barral;   

    public GameObject WormHole_Bullet_blue;
    public GameObject WormHole_Bullet_orange;

    public Animator anim;

    AudioSource Thwump_sound;

    bool anim_toggle=true;

    bool cool_down;

    int speed = 1000;

    private void Start()
    {
        Thwump_sound = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
       if(Input.GetMouseButtonUp(0))
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
                StartCoroutine(delay());
            }
       }
       if(Input.GetKeyDown("i"))
       {
            anim.SetBool("blue", anim_toggle);
            anim_toggle = !anim_toggle;
       }
    }    
    IEnumerator delay()
    {
        yield return new WaitForSeconds(3f);
        cool_down = false;
    }
}
