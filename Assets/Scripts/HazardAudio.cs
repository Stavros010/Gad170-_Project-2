using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpikeAudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip spikeSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            if (spikeSound != null)
            {
                audioSource.PlayOneShot(spikeSound);
            }
        }
    }
}
