using UnityEngine;

public class Musicplayertrue : MonoBehaviour
{
    bool isPlaying = false;
    string currentSong = "";
    public float startVolume = 1.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            PlaySong("Uuuu Steve Lacey");
    }
    void PlaySong(string songName)
    {
        Debug.Log("Now playing:" + songName);
        currentSong = songName;
        isPlaying = true;
    }

    void StopSong()
    {
        Debug.Log(currentSong + " is pauzed");
        isPlaying = false;
    }

    void SetVolume(float volume)
    {
        if (volume >= 0 && volume <= 10)
        {
            Debug.Log("Volume is now: " + volume);
        }
        else
        {
            Debug.Log("Volume kan niet lager");
        }


    }
}
   