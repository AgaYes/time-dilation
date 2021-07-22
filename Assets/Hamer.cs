using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamer : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
private AudioSource _hammerSounds;
private float _speed;
private float _target;
private bool _aga;

    private void Awake ()
    {
        _hammerSounds = GetComponent<AudioSource>();
        _target = 90;
    }

    private void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, _target), _speed * Time.deltaTime);

        if (transform.eulerAngles.z >= 90)
        {
            _target = 0;
        }

        if (transform.eulerAngles.z <= 0)
        {
            _target = 90;
            _hammerSounds.Play();
        }

    }

    public void DilationSpeed ()
    {
        _speed = _speedDilation;
        _hammerSounds.pitch = 0.5f;
    }

    public void NormalSpeed ()
    {
        _speed = _speedNormal;
        _hammerSounds.pitch = 1f;
    }
}
