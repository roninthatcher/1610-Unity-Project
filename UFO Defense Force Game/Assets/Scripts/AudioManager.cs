using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSound[] sounds;

    // Start is called before the first frame update
    void Awake ()
    {
        foreach (AudioSound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play (string name)
    {
        AudioSound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();
    }
}
