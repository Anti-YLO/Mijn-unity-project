using UnityEngine;

public class MusicPlayer : MonoBehaviour
{


    void PlaySong(string songName)
    {
        Debug.Log("Playing song:"+songName);
    }

    void StopSong()
    {
    }

    void SetVolume(float volume)
    {
    }

    string GetCurrentSong()
    {
        return "";
    }

    bool IsPlaying()
    {
        return false;
    }

    void Start()
    {
        PlaySong ("No more parties in LA");
        PlaySong ("Ca$ino");
        PlaySong ("head.rap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

