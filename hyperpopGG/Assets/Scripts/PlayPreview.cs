using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPreview : MonoBehaviour
{
    public AudioSource previewSong;

    public bool startPlaying = false;
    public void reviewSong(){
        startPlaying = true;
        previewSong.Play();
    }
}
