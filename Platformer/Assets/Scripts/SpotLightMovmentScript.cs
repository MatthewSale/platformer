using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightMovmentScript : MonoBehaviour
{
    public int range = 30;
    Light spot_boi;
    private void Start()
    {
        StartCoroutine(delay());
        spot_boi = this.GetComponent<Light>();
    }
    private void Update()
    {
        spot_boi.spotAngle = range;
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.03f);
        
        if(range < 60)
        {
            range = range + 1;
            StartCoroutine(delay());
        }
        else
        {
            StartCoroutine(delay1());
        }
    }

    IEnumerator delay1()
    {
        yield return new WaitForSeconds(0.03f);

        if (range >30 )
        {
            range = range - 1;
            StartCoroutine(delay1());
        }
        else
        {
            StartCoroutine(delay());
        }
    }
}
