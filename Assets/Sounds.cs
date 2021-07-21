using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
   
[SerializeField] private AudioSource _fanSound;
[SerializeField] private AudioSource _hitSound;
[SerializeField] private AudioSource _winSound;
[SerializeField] private AudioSource _dilationSound;
[SerializeField] private AudioClip _clipDilation; 
[SerializeField] private AudioSource _normalTimeSound; 
[SerializeField] private AudioClip _clipNormalTime;


    public void FanSound () => PlaySound (_fanSound);

   // public void HitSound () => PlaySound (_hitSound);

    public void WinSound () => PlaySound (_winSound);

    public void DelationSound () => PlayOneShot (_clipDilation, _dilationSound);

    public void NormalTimeSound () => PlayOneShot (_clipNormalTime, _normalTimeSound);



    private void PlaySound(params AudioSource[] playSource)
    {
        for (int i = 0; i < playSource.Length; i++)
        {
            playSource[i].Play();
        }
    }

    private void PlayOneShot (AudioClip clip, params AudioSource[] playOneShot)
    {
         for (int i = 0; i < playOneShot.Length; i++)
         {
            if (!playOneShot[i].isPlaying)
                playOneShot[i].PlayOneShot(clip);
         }
    }
}