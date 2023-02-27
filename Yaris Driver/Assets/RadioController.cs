using UnityEngine;

public class RadioController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource.clip = audioClips[currentClipIndex];
    }

    void Update()
    {
     
    }

       void OnSpace()
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
        }

        void Onsound()
        {
            currentClipIndex = (currentClipIndex + 1) % audioClips.Length;
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
            Debug.Log("SOund is playing");
        }

        void OnS()
        {
            currentClipIndex--;
            if (currentClipIndex < 0)
            {
                currentClipIndex = audioClips.Length - 1;
            }
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
        }
}
