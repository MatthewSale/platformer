using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceLineManagerScript : MonoBehaviour
{
    public AudioSource ketchup;
    public AudioClip[] audioClip;
    int audio_number;  
    public GameObject Anim1;
    public Material m1;
    public GameObject button1;
    public GameObject audio_checker1;
    public GameObject audio_checker2;    
    public GameObject portal_pedistoolobj;
    public GameObject pause_menu;
    public GameObject audio_checker3;
    public GameObject audio_checker4;
    bool toggle_pause;
    bool start_toggle;

    private void Start()
    {
        ketchup.clip = audioClip[0];
        ketchup.Play();
        StartCoroutine(Delay1());
    }
    private void Update()
    {
        if(audio_number < 0)
        {
            audio_number = 0;
        }

        if(pause_menu.activeInHierarchy)
        {
            ketchup.Pause();
            toggle_pause = true;
            start_toggle = false;
        }
        else
        {
            if (toggle_pause == true)
            {
                ketchup.UnPause();
                toggle_pause = false;
                start_toggle = true;
            }
        }

        if (audio_checker1.activeInHierarchy)
        {                            
            audio_number = 4;                     
            ketchup.Stop();
            audio_checker1.SetActive(false);
        }

        if(audio_checker2.activeInHierarchy)
        {
            audio_number = 6;
            ketchup.Stop();
            audio_checker2.SetActive(false);            
        }

        if (audio_checker3.activeInHierarchy)
        {
            audio_number = 9;
            ketchup.Stop();
            audio_checker3.SetActive(false);
        }

        if (audio_checker4.activeInHierarchy)
        {
            audio_number = 11;
            ketchup.Stop();
            audio_checker4.SetActive(false);
        }

        if (audio_number == 0)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    Debug.Log("fucking audio");
                    audio_number = audio_number + 1;
                }
            }
        }       

        if(audio_number == 1)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[1];
                    audio_number = audio_number + 1;
                    ketchup.Play();
                    StartCoroutine(Delay());                   
                }
            }
        }
        if(audio_number==2)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    audio_number = audio_number + 1;
                    ketchup.clip = audioClip[2];
                    ketchup.Play();
                    button1.GetComponent<Renderer>().material = m1;
                }
            }
        }       

        if(audio_number==4)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[3];
                    ketchup.Play();
                    audio_number = audio_number + 1;
                }
            }
        }

        if (audio_number == 6)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[4];
                    ketchup.Play();
                    audio_number = audio_number + 1;
                }
            }
        }

        if (audio_number == 7)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[5];
                    ketchup.Play();
                    audio_number = audio_number + 1;
                    portal_pedistoolobj.SetActive(true);
                }
            }
        }

        if (audio_number == 9)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[6];
                    ketchup.Play();
                    audio_number = audio_number + 1;                   
                }
            }
        }

        if (audio_number == 11)
        {
            if (start_toggle == true)
            {
                if (!ketchup.isPlaying)
                {
                    ketchup.clip = audioClip[7];
                    ketchup.Play();
                    audio_number = audio_number + 1;
                }
            }
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(9f);
        Anim1.SetActive(true);
    }

    IEnumerator Delay1()
    {
        yield return new WaitForSeconds(3f);
        start_toggle = true;
    }
}
