using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
   
[SerializeField] private AudioSource _hitSound;
[SerializeField] private AudioClip _clipHit;
[SerializeField] private AudioSource _winSound;
[SerializeField] private AudioClip _clipWin;
[SerializeField] private AudioSource _dilationSound;
[SerializeField] private AudioClip _clipDilation; 
[SerializeField] private AudioSource _normalTimeSound; 
[SerializeField] private AudioClip _clipNormalTime;


    public void HitSound () => PlayOneShot (_clipHit, _hitSound);

    public void WinSound () => PlayOneShot (_clipWin, _winSound);

    public void DelationSound (bool active) => PlaySound(active, _dilationSound);

    public void NormalTimeSound (bool active) => PlaySound (active, _normalTimeSound);



    private void PlaySound(bool active, params AudioSource[] playSource)
    {
        for (int i = 0; i < playSource.Length; i++)
        {
            if (active == true)
            {
                playSource[i].Play();
            }

            else
                playSource[i].Stop();
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