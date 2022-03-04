using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawningScript : MonoBehaviour
{
    PlayerControllsMain controlls;

    public GameObject Blue_Indicator;
    public GameObject Orange_Indicator;

    public Transform barral;
   

    public GameObject WormHole_Bullet_blue;
    public GameObject WormHole_Bullet_orange;

    bool cool_down;

    int speed = 1000;

    private void Awake()
    {
        controlls = new PlayerControllsMain();
    //    controlls.GamePlay.FirewormholeGun.performed += con => WormHole();
    }


    void WormHole()
    {
        Debug.Log("plese wormhole here?");
        if (cool_down == false)
        {            
            if (Blue_Indicator.activeInHierarchy)
            {
                GameObject Bullet = Instantiate(WormHole_Bullet_blue, barral.position, Quaternion.identity) as GameObject;
                Bullet.transform.Rotate(new Vector3(barral.rotation.x, barral.rotation.y, barral.rotation.z));
                Rigidbody BulletRigidbody = Bullet.GetComponent<Rigidbody>();
                BulletRigidbody.AddForce(-transform.right * speed);
            }
            else
            {
                GameObject bullet = Instantiate(WormHole_Bullet_blue, barral.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }
            cool_down = true;
            StartCoroutine(delay());
        }
    }

    private void OnEnable()
    {
      //  controlls.GamePlay.Enable();
    }

    private void OnDisable()
    {
       // controlls.GamePlay.Disable();
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        cool_down = false;
    }

}
