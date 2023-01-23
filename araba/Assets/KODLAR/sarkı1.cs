using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarkı1 : MonoBehaviour
{
    public AudioSource source1;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
    public AudioClip clip0;
    public AudioClip clip11;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            source1.PlayOneShot(clip1);

        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            source1.PlayOneShot(clip2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            source1.PlayOneShot(clip3);

        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            source1.PlayOneShot(clip4);

        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            source1.PlayOneShot(clip5);

        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            source1.PlayOneShot(clip6);

        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            source1.PlayOneShot(clip7);

        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            source1.PlayOneShot(clip8);

        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            source1.PlayOneShot(clip9);

        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            source1.PlayOneShot(clip0);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            source1.PlayOneShot(clip11);

        }
    }

}
