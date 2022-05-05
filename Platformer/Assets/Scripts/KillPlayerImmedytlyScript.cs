using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayerImmedytlyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Player"))
        {
            SceneManager.LoadScene("Dead");
        }
    }
}
