using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour
{

[SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
