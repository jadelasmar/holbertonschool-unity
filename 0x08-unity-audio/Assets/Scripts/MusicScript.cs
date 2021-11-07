using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    public AudioClip bgm;

    public AudioSource audioSource;
    public AudioClip winBgm;
    public AudioMixerSnapshot pauseSnapshot;
    public AudioMixerSnapshot resumeSnapshot;
    public AudioMixerSnapshot defaultSnapshot;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgm;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void StopBGM()
    {
        audioSource.Stop();
        audioSource.clip = winBgm;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void pauseSnap()
    {
        pauseSnapshot.TransitionTo(0.2f);
    }

    public void resumeSnap()
    {
        resumeSnapshot.TransitionTo(0.2f);
    }
}