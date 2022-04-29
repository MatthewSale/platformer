using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalParticalHandeler : MonoBehaviour
{
    public GameObject particals;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wormhole cannon")
        {
            Instantiate(particals, new Vector3(other.transform.position.x, other.transform.position.y, this.transform.position.z), Quaternion.Euler(new Vector3(0, 180, 0)));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Wormhole cannon")
        {
            Destroy(GameObject.FindWithTag("Sparks"));
        }
    }
}
