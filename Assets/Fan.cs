using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
[SerializeField] private float _timeWaitDilation;
[SerializeField] private float _timeWaitNormal;
private float _timeWait;
private AudioSource _soundRotate;
private float _speed;

    private void Awake ()
    {
        _speed = _speedNormal;
        _soundRotate = GetComponent<AudioSource>();
        _timeWait = _timeWaitNormal;
        StartCoroutine(WaitAndSound());
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(_speed * Time.deltaTime, 0f, 0f);

    }

    private IEnumerator WaitAndSound ()
    {
        while (true)
        {
            _soundRotate.Play();
            yield return new WaitForSeconds(_timeWait);
            Debug.Log(_timeWait);
        }
    }

    public void DilationSpeed ()
    {
        _speed = _speedDilation;
        _soundRotate.pitch = 0.5f;
        _timeWait = _timeWaitDilation;
    }

    public void NormalSpeed ()
    {
        _speed = _speedNormal;
        _soundRotate.pitch = 1f;
        _timeWait = _timeWaitNormal;
    }
}
