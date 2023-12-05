using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Audio[] audioClips;
    private void Awake() 
    {
        foreach(Audio audio in audioClips)
        {
            audio.source = gameObject.AddComponent<AudioSource>();
            audio.source.clip = audio.clip;
            audio.source.volume = audio.volume;
        }
    }
    public void Play(string name)
    {
        foreach(Audio audio in audioClips)
        {
            if(audio.name == name)
            {
                audio.source.Play();
            }
        }
    }
}
