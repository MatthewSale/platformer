using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHoleBUlletSctipr : MonoBehaviour
{
    GameObject self;
    public GameObject portal;
    public bool worm_hole_is_blue;
    private void Start()
    {
        self = this.gameObject;

        self.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
    }

    private void Update()
    {
        if(worm_hole_is_blue == true)
        {
            portal = GameObject.FindGameObjectWithTag("Portal1");
        }
        else
        {
            portal = GameObject.FindGameObjectWithTag("Portal2");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        portal.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1f, this.transform.position.z);
        portal.transform.rotation = new Quaternion(this.transform.rotation.w + 90f, 0f, this.transform.rotation.y +90f,0f);
        Destroy(self);
    }
}
