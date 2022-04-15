using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour {

	public Transform playerCamera;
	public GameObject Player_modle;
	public Transform portal;
	public Transform otherPortal;
	Transform offset_holder;
	int player_height;
	
	void Update () {
		Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;		 
		this.transform.position = portal.position + playerOffsetFromPortal;
		



		float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

		Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
		Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;		
		this.transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
	}
}
