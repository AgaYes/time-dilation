using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
private AudioSource _soundRotate;
private float _speed;

    private void Awake ()
    {
        _speed = _speedNormal;
        _soundRotate = GetComponent<AudioSource>();
        _soundRotate.Play();
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(_speed * Time.deltaTime, 0f, 0f);
    }

    public void DilationSpeed ()
    {
        _speed = _speedDilation;
        _soundRotate.pitch = 0.5f;
    }

    public void NormalSpeed ()
    {
        _speed = _speedNormal;
        _soundRotate.pitch = 1f;
    }
}
