using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject Player;
    public Vector3 center;
    public bool is_portal_1;
    public bool cool_down = false;
    GameObject portal_this;
    public GameObject portal_linking;

    private void Start()
    {
        if(this.tag==("Portal1"))
        {
            is_portal_1 = true;
        }
    }

    private void Update()
    {
        center = Player.GetComponent<Renderer>().bounds.center;
      
        if(is_portal_1 == true)
        {
            portal_this = GameObject.FindGameObjectWithTag("Portal1");
            portal_linking = GameObject.FindGameObjectWithTag("Portal2");
        }
        else
        {
            portal_this = GameObject.FindGameObjectWithTag("Portal2");
            portal_linking = GameObject.FindGameObjectWithTag("Portal1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==("Player"))
        {
            TestingMovmentScript tm = Player.GetComponent<TestingMovmentScript>();            
            if (cool_down == false)
            {
                Player.transform.position = new Vector3(portal_linking.transform.position.x, portal_linking.transform.position.y, portal_linking.transform.position.z);
               // Player.transform.rotation = new Quaternion(portal_linking.transform.rotation.w, portal_linking.transform.rotation.x, portal_linking.transform.rotation.y, portal_linking.transform.rotation.z);
                StartCoroutine(Delay());
                cool_down = true;
               PortalScript pm = portal_linking.GetComponent<PortalScript>();
               pm.cool_down = true;
               pm.StartCoroutine(Delay());
               Debug.Log("portal time baby");
            }
           
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
        cool_down = false;
    }
}
