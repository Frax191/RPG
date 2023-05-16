using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    private AudioSource audioSource;

    public AudioClip song;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySong();
    }

    private void PlaySong()
    {
        if (song != null)
        {
            audioSource.clip = song;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No song assigned to MusicManager.");
        }
    }
    public void StopSong()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
