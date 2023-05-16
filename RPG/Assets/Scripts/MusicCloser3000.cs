using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCloser3000 : MonoBehaviour
{
    void Start()
    {
        MusicManager musicManager = FindObjectOfType<MusicManager>();
        if (musicManager != null)
        {
            musicManager.StopSong();
        }
    }
}
