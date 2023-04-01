using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class AudioSound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
