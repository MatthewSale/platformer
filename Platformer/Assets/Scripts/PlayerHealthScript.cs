using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealthScript : MonoBehaviour
{
    public float Player_health;
    public float Delay_value;
    bool toggle = true;
    public Slider slider_delayed;
    public Slider slider_sudden;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Damage"))
        {
            Delay_value = Delay_value - (Random.Range(10, 50));
        }
    }

    private void Update()
    {
        if(Delay_value < Player_health)
        {
            if(toggle == true)
            {
                StartCoroutine(delay1());
                toggle = false;
            }
        }
        slider_delayed.value = Player_health;
        slider_sudden.value = Delay_value;

        if(Delay_value <= 0)
        {
            SceneManager.LoadScene("Dead");
        }
    }

    IEnumerator delay1()
    {
        yield return new WaitForSeconds(0.8f);
        StartCoroutine(delay());
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.001f);

        if (Delay_value < Player_health)
        {
            StartCoroutine(delay());
            Player_health = Player_health - 0.14f;
        }
        else
        {
            toggle = true;
        }
    }
}
