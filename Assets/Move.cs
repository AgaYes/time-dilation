using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

[SerializeField] private float _speed;
[SerializeField] private Ui _ui;
[SerializeField] private EnergyBar _energyBar;
[SerializeField] private TimeDilation _timeDilation;
[SerializeField] private Sounds _sounds;
private float _currentEnergy;
public bool _isAlive { private get; set; }
private bool _normalTime;

    private void Start ()
    {
        _currentEnergy = _energyBar._maxEnergy;
        _isAlive = true;
        _normalTime = true;
        _timeDilation.NormalTime();
    }

    private void Update()
    {
        if (_isAlive == true)
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);

            if (Input.GetMouseButton(0) && _currentEnergy > 0)
            {
                if (_normalTime == true)
                {
                    _ui.TimeScreen("slow");
                    _sounds.DelationSound();
                    _timeDilation.TimeDil();
                }

                _currentEnergy = _energyBar.SetEnergy(_currentEnergy);
                _normalTime = false;
            }

            else if (_normalTime == false)
            {
                _ui.TimeScreen("normal");
                _sounds.NormalTimeSound();
                _timeDilation.NormalTime();
                _normalTime = true;
            }

            if (_currentEnergy < 1 && !Input.GetMouseButton(0))
            {
                _currentEnergy = _energyBar.EnergyRecovery(_currentEnergy);
            }

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began && _currentEnergy > 0)
                {
                    _timeDilation.TimeDil();
                    _currentEnergy = _energyBar.SetEnergy(_currentEnergy);
                }
            }

        }

        else
            _timeDilation.NormalTime();
    }
}
