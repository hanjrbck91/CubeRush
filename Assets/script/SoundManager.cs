using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;   

    [SerializeField] private AudioSource _backgroundMusic;
    [SerializeField] private GameObject SoundIcon;
    [SerializeField] private GameObject MuteSoundIcon;

    [SerializeField] private AudioSource ButtonclickSound;
    [SerializeField] private AudioSource LevelUpSound;

    private void Awake()
    {
        instance = this;

        SoundIcon.SetActive(true);
        MuteSoundIcon.SetActive(false);
    }
    public void OnSoundButtonclicked()
    {
        _backgroundMusic.volume = 0;
        SoundIcon.SetActive(false);
        MuteSoundIcon.SetActive(true);
        
    }
    public void OnMuteSoundButtonclicked()
    {
        _backgroundMusic.volume = .6f;
        SoundIcon.SetActive(true );
        MuteSoundIcon.SetActive(false);
    }

    public void ButtonClickSound()
    {
        ButtonclickSound.Play();   
    }

    public void UpdateLevelSound()
    {
        LevelUpSound.Play();
    }


}
