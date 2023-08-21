using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;

    void Update()
    {
        audioSource.volume = slider.value;
    }
}
