using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;
public class AudVolControl : MonoBehaviour
{
    EventInstance sfxVolumePreview, voiceVolumePreview;

    Bus mastP, musicP, sfxP, voiceP;

    public float masterVolume = 0.5f, musicVolume = 0.5f, sfxVolume = 0.5f, voiceVolume = 0.5f;

    void Awake()
    {
        mastP = RuntimeManager.GetBus("bus:/FakeMaster");
        sfxP = RuntimeManager.GetBus("bus:/FakeMaster/SFXBus");
        musicP = RuntimeManager.GetBus("bus:/FakeMaster/MusicBus");
        voiceP = RuntimeManager.GetBus("bus:/FakeMaster/VoiceBus");

    }

    void Update()
    {
        mastP.setVolume(masterVolume);
        musicP.setVolume(musicVolume);
        sfxP.setVolume(sfxVolume);
        voiceP.setVolume(voiceVolume);
    }

    public void MasterVolumeLevel(float newMasterVolume)
    {
        masterVolume = newMasterVolume;
    }

    public void MusicVolumeLevel(float newMusicVolume)
    {
        musicVolume = newMusicVolume;
    }

    public void SFXVolumeLevel(float newSFXVolume)
    {
        sfxVolume = newSFXVolume;
    }

    public void VoiceVolumeLevel(float newVoiceVolume)
    {
        voiceVolume = newVoiceVolume;
    }
}
