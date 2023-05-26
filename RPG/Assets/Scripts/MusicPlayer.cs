using UnityEngine;
using static DialogueManager;
using static EnemyTrigger;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] musicTracks;
    private AudioSource audioSource;
    private int currentTrackIndex = 0;
    private bool isPaused = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayTrack(currentTrackIndex);
    }

    private void PlayTrack(int trackIndex)
    {
        audioSource.clip = musicTracks[trackIndex];
        audioSource.Play();
    }

    private void Update()
    {
        if (!audioSource.isPlaying && !isPaused)
        {
            PlayNextTrack();
        }
    }

    private void PlayNextTrack()
    {
        currentTrackIndex = (currentTrackIndex + 1) % musicTracks.Length;
        PlayTrack(currentTrackIndex);
    }

    public void TogglePause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            isPaused = true;
        }
        else
        {
            audioSource.UnPause();
            isPaused = false;
        }
    }
}
