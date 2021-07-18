﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

[SerializeField] private Ui _ui;
[SerializeField] private Move _move;
[SerializeField] private RegDoll _regDoll;
private Rigidbody _rb;

    private void Start ()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Dead ();
            _regDoll.Active();
        }

        if (col.gameObject.tag == "Finish")
        {

        }
    }

    private void Dead ()
    {
        Time.timeScale = 0f;
        _ui.DeadDisplay();
        _move._isAlive = false;
    }

    private void Win ()
    {
        Time.timeScale = 0f;
        _ui.WinDisplay();
    }
}
