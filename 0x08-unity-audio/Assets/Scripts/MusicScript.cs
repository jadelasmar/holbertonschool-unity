using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    public AudioClip bgm;

    public AudioSource audioSource;
    public AudioClip winBgm;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgm;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void stopBGM()
    {
        audioSource.Stop();
        audioSource.clip = winBgm;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
