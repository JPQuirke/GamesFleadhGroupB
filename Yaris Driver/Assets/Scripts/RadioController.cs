using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioController : MonoBehaviour
{
    public AudioSource audioSource; // The component used to play audio
    public AudioClip[] audioClips;
    public Text songName; // Reference to the Text object for the song name
    private int currentClipIndex = 0; // The index of the currently playing song

    void Start()
    {
        audioSource.clip = audioClips[currentClipIndex]; // Set the clip to the first audio clip in the array
        audioSource.Play(); // Start playing the radio

        // Set the initial song name in the Text object with prefix
        songName.text = "Song Name: " + audioSource.clip.name;
    }

    void Update()
    {
        
    }

    void OnSpace() 
    {
        if (audioSource.isPlaying) // Check if audio playing
        {
            audioSource.Pause(); // Pause the audio
        }
        else
        {
            audioSource.Play(); // Play Audio
        }
    }

    void OnF() //when pressed changes to the previous song.
    {
        currentClipIndex = (currentClipIndex + 1) % audioClips.Length;
        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();

        // Set the new song name in the Text object with prefix
        songName.text = "Song Name: " + audioSource.clip.name;
    }

    void OnG() //when pressed changes to the next song.
    {
        currentClipIndex--;
        if (currentClipIndex < 0)
        {
            currentClipIndex = audioClips.Length - 1;
        }
        audioSource.clip = audioClips[currentClipIndex];
        audioSource.Play();

        // Set the new song name in the Text object with prefix
        songName.text = "Song Name: " + audioSource.clip.name;
    }
}
