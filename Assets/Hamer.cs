using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamer : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
private float _speed;
private float _target;

    private void Start ()
    {
        _target = 90;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, _target), _speed * Time.deltaTime);

        if (transform.eulerAngles.z >= 89)
        {
            _target = 0;
        }

        else if (transform.eulerAngles.z <= 1)
        {
            _target = 90;
        }
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
