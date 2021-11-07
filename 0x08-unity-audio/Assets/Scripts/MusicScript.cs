using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicScript : MonoBehaviour
{
    public AudioClip bgm;

    private AudioSource audioSource;
    public AudioClip winBgm;
    public AudioMixerSnapshot pauseSnapshot;
    public AudioMixerSnapshot resumeSnapshot;
    public AudioMixerSnapshot defaultSnapshot;
    private float BGMvolume;
    private float SFXvolume;
    public AudioMixer audioMixer;

    // Start is called before the first frame update
    void Start()
    {
        BGMvolume = PlayerPrefs.GetFloat(PlayerPrefKeys.bgmVolume,defaultValue:0.2f);
        SFXvolume = PlayerPrefs.GetFloat(PlayerPrefKeys.sfxVolume,defaultValue:0.5f);

        audioMixer.SetFloat("bgmVolume", LinearToDecibel(BGMvolume));
        audioMixer.SetFloat("sfxVolume", LinearToDecibel(SFXvolume));

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

    private float LinearToDecibel(float linear)
    {
        float dB;

        if (linear != 0)
            dB = 20.0f * Mathf.Log10(linear);
        else
            dB = -144.0f;

        return dB;
    }

    private float DecibelToLinear(float dB)
    {
        float linear = Mathf.Pow(10.0f, dB / 20.0f);

        return linear;
    }
}