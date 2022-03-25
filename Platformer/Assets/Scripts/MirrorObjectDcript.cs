using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorObjectDcript : MonoBehaviour
{
    public GameObject Player;
    GameObject Portal;
    
    public Vector3 mirrored_transform;
    public Transform players_position;
    Vector3 offset_position;
    Vector3 portal_position;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Portal = GameObject.FindGameObjectWithTag("p");
    }

    private void Update()
    {
        players_position = Player.transform;

        offset_position = portal_position - new Vector3(players_position.position.x, players_position.position.y, players_position.position.z);


        mirrored_transform = new Vector3(players_position.position.x, -players_position.position.y, -players_position.position.z) + offset_position;        
        this.transform.position = mirrored_transform;
    }
}
