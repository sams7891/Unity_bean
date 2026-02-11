using UnityEditor.ShaderGraph.Internal;
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
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audio in allAudioSources)
        {
            audio.volume = value;
        }
    }

}
