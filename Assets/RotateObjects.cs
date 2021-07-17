using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
private float _speed;

    private void Start ()
    {
        _speed = _speedNormal;
    
    }

    private void Update()
    {
        transform.rotation *= Quaternion.Euler(_speed * Time.deltaTime, 0f, 0f);
    }

    public void DilationSpeed ()
    {
        _speed = _speedDilation;
    }

    public void NormalSpeed ()
    {
        _speed = _speedNormal;
    }
}
