using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundMAnager : MonoBehaviour
{
  private AudioSource audioSource;

    public GameObject SoundCheck;
    public AudioClip BGM;
    public AudioMixer masterMixer;
    public Slider audioSlider;
   
    void Start()
    {
        
      

        

        
        audioSource = GetComponent<AudioSource>();
    }

    public void AudioControl()
    {
        float sound = audioSlider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", sound);
    }

   

    public void ToggleAudioVolume()
    {   
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
        SoundCheck.GetComponent<SpriteRenderer>().color = Color.red;

    }
}
