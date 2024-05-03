using UnityEngine;
using UnityEngine.Video;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField]
    private AudioReverbZone reverbZone_;
    [SerializeField]
    private AudioClip[] songs_;

    [SerializeField]
    private GameObject screen_;
    [SerializeField]
    private VideoClip[] videos_;

    private int count_ = 0;

    public void ChangeSong()
    {
        reverbZone_.GetComponent<AudioSource>().clip = songs_[count_];
        reverbZone_.GetComponent<AudioSource>().Play();

        screen_.GetComponent<VideoPlayer>().clip = videos_[count_];
        screen_.GetComponent<VideoPlayer>().Play();

        count_++;
        if (count_ >= songs_.Length || count_ >= videos_.Length)
        {
            count_ = 0;
        }       
    }
}
