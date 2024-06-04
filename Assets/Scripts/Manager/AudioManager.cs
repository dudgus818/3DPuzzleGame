using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource backgroundMusicSource;
    public AudioSource soundEffectSource;
    public AudioSource musicBoxSource;
    public AudioSource mapLampSource;
    public AudioSource LampSource;

    public AudioClip backgroundMusicClip;
    public AudioClip runMusicClip;
    public AudioClip clickSound;
    public AudioClip setSound;
    public AudioClip mapLampSound;
    public AudioClip lampSound;
    public AudioClip openInventorySound;
    public AudioClip musicboxSound;
    public AudioClip doorOpenSound;
    public AudioClip SecretdoorOpenSound;
    public AudioClip useKeySound;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayClickSound()
    {
        if (clickSound != null)
        {
            soundEffectSource.clip = clickSound;
            soundEffectSource.Play();
        }
    }
    public void PlayInventorySound()
    {
        if (clickSound != null)
        {
            soundEffectSource.clip = openInventorySound;
            soundEffectSource.Play();
        }
    }

    public void BackGroundtMusic()
    {
        if (backgroundMusicClip != null)
        {
            backgroundMusicSource.clip = backgroundMusicClip;
            backgroundMusicSource.Play();
        }
    }

    public void RunMusic()
    {
        if (backgroundMusicClip != null)
        {
            backgroundMusicSource.clip = runMusicClip;
            backgroundMusicSource.Play();
        }
    }

    public void PlayMusicBox()
    {
        if (musicboxSound != null)
        {
            musicBoxSource.clip = musicboxSound;
            musicBoxSource.Play();
        }
    }

    public void StopMusicPlay()
    {
        if (backgroundMusicSource != null)
        {
            backgroundMusicSource.Stop();
        }
    }

}
