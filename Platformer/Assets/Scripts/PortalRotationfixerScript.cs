using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRotationfixerScript : MonoBehaviour
{
    private void Update()
    {
       new Quaternion(this.transform.rotation.w, this.transform.rotation.x,this.transform.rotation.y, this.transform.transform.rotation.z);
    }
}
