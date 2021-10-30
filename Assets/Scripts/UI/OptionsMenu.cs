using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider volumeSlider;

    public void OnVolumeSlide()
    {
        AudioListener.volume = volumeSlider.value;
        Debug.Log("Volume: " + volumeSlider.value);
    }
}
