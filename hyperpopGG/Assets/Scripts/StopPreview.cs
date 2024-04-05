using UnityEngine;

public class StopPreview : MonoBehaviour
{
    public AudioSource previewSong;

    public void StopSong()
    {
        previewSong.Stop();
    }
}
