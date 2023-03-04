using UnityEngine;

public class RadioController : MonoBehaviour
{
    public AudioSource audioSource; // The component used to play audio
    public AudioClip[] audioClips; // An array of audio clips to play from
    private int currentClipIndex = 0; // The index of the currently playing song

    void Start()
    {
        audioSource.clip = audioClips[currentClipIndex]; // Set the clip to the first audio clip in the array
        audioSource.Play(); // Start playing the radio
    }

    void Update()
    {
     
    }

    void OnSpace() // Function to handle the space key press
    {
        if (audioSource.isPlaying) // If the audio is playing
        {
            audioSource.Pause(); // Pause the audio
        }
        else
        {
            audioSource.Play(); // Otherwise, play the audio
        }
    }

    void On2() // Function to handle if the 2 key is pressed
    {
        currentClipIndex = (currentClipIndex + 1) % audioClips.Length; // Increment by 1 the index and wrap around if necessary
        audioSource.clip = audioClips[currentClipIndex]; // Set the clip to the new audio clip
        audioSource.Play(); // Play the new audio clip
        Debug.Log("Sound is playing"); // Give a printed confirmation that sound is playing
    }

    void On1() // Function to handle if the 1 key is press
    {
        currentClipIndex--; // Decrement the index by -1
        if (currentClipIndex < 0) // If the index is less than zero
        {
            currentClipIndex = audioClips.Length - 1; // Wrap around to the end of the array
        }
        audioSource.clip = audioClips[currentClipIndex]; // Set the clip to the new audio clip
        audioSource.Play(); // Play the new audio clip
    }
}
