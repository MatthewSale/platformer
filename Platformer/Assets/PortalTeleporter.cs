using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
	public Transform reciever;

	int crack_variable;

	AudioSource Audio_hanadler;
	public AudioClip [] crack;

	public AudioClip crack_1;
	public AudioClip crack_2;
	public AudioClip crack_3;
	public AudioClip crack_4;
	public AudioClip crack_5;

	private bool playerIsOverlapping = false;


    private void Start()
    {
		Audio_hanadler = this.GetComponent<AudioSource>();
		crack[0] = crack_1;
		crack[1] = crack_2;
		crack[2] = crack_3;
		crack[3] = crack_4;
		crack[4] = crack_5;
	}

    void Update () 
	{
		if (playerIsOverlapping)
		{
			Vector3 portalToPlayer = player.position - transform.position;
			float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

			// If this is true: The player has moved across the portal
			if (dotProduct < 0f)
			{
				// Teleport him!
				float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
				rotationDiff += 180;
				player.Rotate(Vector3.up, rotationDiff);

				Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
				player.position = reciever.position + positionOffset;

				playerIsOverlapping = false;
			}
		}
	}
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			playerIsOverlapping = true;

			crack_variable = Random.Range(0, 10);
			
			if(crack_variable == 4)
            {	
				Audio_hanadler.clip = crack[Random.Range(0, crack.Length)];
				Audio_hanadler.Play();
            }
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player")
		{
			playerIsOverlapping = false;
		}
	}
}
