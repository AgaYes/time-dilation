using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

[SerializeField] private Ui _ui;
[SerializeField] private Move _move;
[SerializeField] private RegDoll _regDoll;
[SerializeField] private Sounds _sounds;
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
        }

        if (col.gameObject.tag == "Finish")
        {
            _ui.WinDisplay();
        }

        if (col.gameObject.tag == "Boat")
        {
            Boat(col.gameObject);
        }
    }

    private void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Dead();
        }
    }

    private void Dead ()
    {
        _ui.DeadDisplay();
        //_sounds.HitSound();
        _regDoll.Active();
        Debug.Log("sfd");
    }

    private void Win ()
    {
        _ui.WinDisplay();
        _sounds.WinSound();
    }

    private void Boat (GameObject boat)
    {
        this.transform.SetParent(boat.transform);
        boat.GetComponent<BoatMove>().enabled = true;
        _regDoll.Active();
    }
}
