using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CamfraFadeScript : MonoBehaviour
{
    public Color Black;
    public Image fade_cube;
    float alfa = 1;
    float Scale = 0.001f;
    public GameObject Canvus;
    
    private void Start()
    {
        StartCoroutine(delay1());
    }

    private void Update()
    {
        Black.a = alfa;
        fade_cube.color = Black;

        if(alfa <= 0f)
        {
            Destroy(Canvus);
        }
    }

    IEnumerator delay1()
    {
        yield return new WaitForSeconds(3f);        
        StartCoroutine(delay());        
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.001f);
        alfa = alfa - Scale;
        Scale = Scale + 0.0001f;
        StartCoroutine(delay());
        Debug.Log("ticking");
    }
}
