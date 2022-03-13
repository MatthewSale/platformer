using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFowardAlways : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(Vector3.forward*1);
    }
}
