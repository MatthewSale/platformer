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

    private void Awake()
    {
        controlls = new PlayerControllsMain();
        controlls.GamePlay.FirewormholeGun.performed += con => WormHole();
    }


    void WormHole()
    {
        Debug.Log("plese wormhole here?");
        if (cool_down == false)
        {
            if (Blue_Indicator.activeInHierarchy)
            {
                Instantiate(WormHole_Bullet_blue, new Vector3(barral.position.x, barral.position.y, barral.position.z),new Quaternion(this.transform.rotation.w, this.transform.rotation.x, this.transform.rotation.y, this.transform.rotation.z));
            }
            else
            {
                Instantiate(WormHole_Bullet_orange, new Vector3(barral.position.x, barral.position.y, barral.position.z), Quaternion.identity);
            }
            cool_down = true;
            StartCoroutine(delay());
        }
    }


    private void OnEnable()
    {
        controlls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controlls.GamePlay.Disable();
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        cool_down = false;
    }

}
