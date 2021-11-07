using UnityEngine;
using UnityEngine.Audio;

public class audioScript : MonoBehaviour
{
    public PlayerController playerController;
    public AudioSource audioSource;
    public AudioClip footGrass;

    public AudioMixer audioMixer;

    // Start is called before the first frame update
    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void Update()

    {
        if (playerController.isRunning)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = footGrass;
                audioSource.loop = true;
                audioSource.outputAudioMixerGroup = audioMixer.FindMatchingGroups("Running")[0];
                audioSource.Play();
            }
        }
        else
        {
            audioSource.loop = false;
        }
    }
}