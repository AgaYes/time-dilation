using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{

[SerializeField] private float _speedNormal;
[SerializeField] private float _speedDilation;
[SerializeField] private Transform[] _targetPosition = new Transform[2];
private Transform _target;
private float _speed;

    private void Awake ()
    {
        _target = _targetPosition[0];
        _speed = _speedNormal;
    }

    private void Update()
    {
       MoveSaw (_target);

        if (transform.position == _targetPosition[0].position)
        {
            
            _target = _targetPosition[1];
        }

        else if (transform.position == _targetPosition[1].position)
        {
            _target = _targetPosition[0];
        }
    }

    private void MoveSaw (Transform targets)
    {
        transform.position = Vector3.MoveTowards(transform.position, targets.position, _speed * Time.deltaTime);
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
