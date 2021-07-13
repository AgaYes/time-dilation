using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

public float _speedRotate { private get; set; }
public float _speedMove { private get; set; }
private float timer;
[SerializeField] private float _speedSaw;
[SerializeField] private float _speedRotateSaw;
[SerializeField] private float _speedDilation;
[SerializeField] private Transform[] _targetPosition = new Transform[2];


    private void Start ()
    {
        _speedMove = _speedSaw;
        _speedRotate = _speedRotateSaw;
    }

    void Update()
    {
        //transform.rotation *= Quaternion.Euler(_speedRotate * Time.deltaTime, 0, 0);
        transform.Translate(transform.right * _speedMove * Time.deltaTime);
       // transform.position = Vector3.Lerp(_targetPosition[0].position, _targetPosition[1].position, Mathf.PingPong(timer, _speedMove));
       // timer += Time.deltaTime;

        if (Vector3.Distance(transform.position, _targetPosition[0].position) < 0.3f || Vector3.Distance(transform.position, _targetPosition[1].position) < 0.3f)
        {
            _speedMove *= -1;
            _speedSaw *= -1;
            _speedDilation *= -1;
        } 
    }

    public void DilationSpeed ()
    {
        _speedMove = _speedDilation;
    }

    public void NormalSpeed ()
    {
        _speedMove = _speedSaw;
        //_speedRotate = _speedRotateSaw;
    }
}
