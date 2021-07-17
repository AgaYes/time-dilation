using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{

[SerializeField] private float _speedDilation;
[SerializeField] private float _speedNormal;
private float _speed;

[SerializeField] private Transform[] _press = new Transform[2];
[SerializeField] private Transform[] _startPosition = new Transform[2];
private Transform[] _target;

    private void Start ()
    {
        _target = _press;
        _speed = _speedNormal;
    }

    private void Update()
    {
        MovePress (_target);

        if (_press[0].position == _startPosition[1].position)
        {
            _target = _press;
        }

        if (_press[0].position == _press[1].position)
        {
            _target = _startPosition;
        }
    }

    private void MovePress (Transform[] targetPosition)
    {
        _press[0].position = Vector3.MoveTowards(_press[0].position, targetPosition[1].position, _speed); 
        _press[1].position = Vector3.MoveTowards(_press[1].position, targetPosition[0].position, _speed); 
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
