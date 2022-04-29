using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparksMirrorScripts : MonoBehaviour
{
    GameObject wormhole_cannon;
    GameObject render_plane;

    private void Start()
    {
        wormhole_cannon = GameObject.FindGameObjectWithTag("Wormhole cannon");
        render_plane = GameObject.FindGameObjectWithTag("renderPlane");
    }

    private void Update()
    {
        this.transform.position = new Vector3(wormhole_cannon.transform.position.x, wormhole_cannon.transform.position.y,render_plane.transform.position.z);
        this.transform.rotation = render_plane.transform.rotation;
    }
}
