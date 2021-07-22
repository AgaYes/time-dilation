using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{

private List <MoveObjects> _moveObjects = new List<MoveObjects>();
private List <RotateObjects> _rotateObjects = new List<RotateObjects>();
private List <Press> _press = new List<Press>();
private List <Hamer> _hammer = new List<Hamer>();
private List <Fan> _fan = new List<Fan>();

    private void Start ()
    {
        var moveObjects = FindObjectsOfType<MoveObjects>();
        _moveObjects.AddRange(moveObjects);

        var rotateObjects = FindObjectsOfType<RotateObjects>();
        _rotateObjects.AddRange(rotateObjects);

        var pressObjects = FindObjectsOfType<Press>();
        _press.AddRange(pressObjects);

        var hammerObjects = FindObjectsOfType<Hamer>();
        _hammer.AddRange(hammerObjects);

        var fanObjects = FindObjectsOfType<Fan>();
        _fan.AddRange(fanObjects);
    }

    public void TimeDil ()
    {
        for (int i = 0; i < _moveObjects.Count; i++)
        {
            _moveObjects[i].DilationSpeed();
        }

        for (int i = 0; i < _rotateObjects.Count; i++)
        {
            _rotateObjects[i].DilationSpeed();
        }

        for (int i = 0; i < _press.Count; i++)
        {
            _press[i].DilationSpeed();
        }

        for (int i = 0; i < _hammer.Count; i++)
        {
            _hammer[i].DilationSpeed();
        }

        for (int i = 0; i < _fan.Count; i++)
        {
            _fan[i].DilationSpeed();
        }
    }

    public void NormalTime ()
    {
        for (int i = 0; i < _moveObjects.Count; i++)
        {
            _moveObjects[i].NormalSpeed();
        }

        for (int i = 0; i < _rotateObjects.Count; i++)
        {
            _rotateObjects[i].NormalSpeed();
        }

        for (int i = 0; i < _press.Count; i++)
        {
            _press[i].NormalSpeed();
        }

        for (int i = 0; i < _hammer.Count; i++)
        {
            _hammer[i].NormalSpeed();
        }

         for (int i = 0; i < _fan.Count; i++)
        {
            _fan[i].NormalSpeed();
        }
    }
}
