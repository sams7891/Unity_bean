using UnityEngine;
using UnityEngine.UI;

public class soundChanger : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        UpdateVolume(volumeSlider.value);
        volumeSlider.onValueChanged.AddListener(UpdateVolume);
    }

    void UpdateVolume(float value)
    {
#pragma warning disable CS0618 // Type or member is obsolete
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
#pragma warning restore CS0618 // Type or member is obsolete

        foreach (AudioSource audio in allAudioSources)
        {
            audio.volume = value;
        }
    }

}
