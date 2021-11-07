using UnityEngine;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    private PlayerController playerController;
    private AudioSource audioSource;
    public AudioClip footGrass;
    public AudioClip grassLanding;

    public AudioMixer audioMixer;

    // Start is called before the first frame update
    private void Start()
    {
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()

    {
        if (playerController.isRunning)
        {
            if (audioSource.isPlaying) return;
            audioSource.clip = footGrass;
            audioSource.loop = true;
            audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Running")[0];
            audioSource.Play();
        }
        else
        {
            audioSource.loop = false;
        }

        if (playerController.madeImpact)
        {
            
            if (audioSource.isPlaying) return;
            audioSource.clip = grassLanding;
            audioSource.loop = false;
            audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Landing")[0];
            audioSource.Play();
        }
    }
}