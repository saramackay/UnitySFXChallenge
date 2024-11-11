using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePlayScript : MonoBehaviour
{

    public AudioClip AETHER;

    private AudioSource audioSource;
    private bool paused1;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        paused1 = true;
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Play song"))
        {
            if (paused1)
            {
                audioSource.clip = AETHER;
                audioSource.Play(0);
                paused1 = false;
            }
        }

        if (GUI.Button(new Rect(250, 10, 200, 100), "Pause song"))
        {
            if (paused1 == false)
            {
                audioSource.Pause();
                paused1 = true;
            }
        }
    }
}
