using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Audio
{
    public string name;
    public AudioClip clip;
    [Range(0, 1)]
    [SerializeField] public float volume;
    [HideInInspector]
    public AudioSource source;
}
