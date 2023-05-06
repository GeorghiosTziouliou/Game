using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    bool hasPlayedSound = false;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!hasPlayedSound && other.CompareTag("Player"))
        {
            // Play the sound
            audioSource.Play();
        
            // Set hasPlayedSound to true
            hasPlayedSound = true;
        }
    }

}