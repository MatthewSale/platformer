using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormHoleBUlletSctipr : MonoBehaviour
{    
    public GameObject portal;
    public GameObject portal_rotation_holder;
    public bool worm_hole_is_blue;
    GameObject Player;
    GameObject inverse_player;
    public GameObject sound_cube;
    
    private void Start()
    {
        
        if (worm_hole_is_blue == true)
        {
            portal = GameObject.FindGameObjectWithTag("Portal1");
        }
        else
        {
            portal = GameObject.FindGameObjectWithTag("Portal2");
        }
        Player = GameObject.FindGameObjectWithTag("Player");
        inverse_player = GameObject.FindGameObjectWithTag("InversePlayer");
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(sound_cube, this.transform.position, Quaternion.identity);
        portal.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z);
        if (worm_hole_is_blue == true)
        {
            portal.transform.rotation = Player.transform.rotation;
        }
        else
        {
            portal.transform.rotation = inverse_player.transform.rotation;
        }
        Destroy(gameObject);
    }
}
