using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class SoundOnClickButton : MonoBehaviour
{
    private Button button;
    private AudioSource audio;
    public AudioClip sound;

    private void Start() {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);

        audio = GetComponent<AudioSource>();
        audio.clip = sound;
    }

    private void OnClick() {
        print("Playing");
        audio.Play();
    }
}
