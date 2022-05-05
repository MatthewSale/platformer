using UnityEngine;
using System.Collections;

public class ScrollingUVs_Layers : MonoBehaviour 
{
	//public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
	public string textureName = "_MainTex";
    float range;
	Vector2 uvOffset = Vector2.zero;

    private void Start()
    {
        StartCoroutine(delay());
    }

    void LateUpdate() 
	{
		uvOffset += ( uvAnimationRate * Time.deltaTime );
		if( GetComponent<Renderer>().enabled )
		{
			GetComponent<Renderer>().sharedMaterial.SetTextureOffset( textureName, uvOffset );
		}

        uvAnimationRate.y = range;
	}

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.3f);

        if (range < 0.5f)
        {
            range = range + 0.001f;
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

        if (range > -0.5f)
        {
            range = range - 0.01f;
            StartCoroutine(delay1());
        }
        else
        {
            StartCoroutine(delay());
        }
    }
}