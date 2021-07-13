using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{

private List<Saw> _saw = new List<Saw>();

    private void Start ()
    {
        var saw = FindObjectsOfType<Saw>();
        _saw.AddRange(saw);
        Debug.Log(_saw);
    }

    public void TimeDil ()
    {
        for (int i = 0; i < _saw.Count; i++)
        {
            _saw[i].DilationSpeed();
            //_saw[i]._speedRotate = _speedRotateSaw;
        }
    }

    public void NormalTime ()
    {
        for (int i = 0; i < _saw.Count; i++)
        {
            _saw[i].NormalSpeed();
        }
    }
}
