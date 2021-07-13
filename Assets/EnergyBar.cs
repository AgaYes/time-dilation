using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

[SerializeField] private Slider _slider;

[SerializeField] public float _maxEnergy;

[SerializeField] private float _wasteEnergy;
[SerializeField] private float _getEnergy;


    private void Start ()
    {
        _slider.value = _maxEnergy;
    }

    public float SetEnergy (float currentEnergy)
    {
        currentEnergy -= _wasteEnergy;
        _slider.value = currentEnergy;

        return currentEnergy;
    }

    public float EnergyRecovery (float currentEnergy)
    {
        if(currentEnergy <= 1)
        {
            currentEnergy += _getEnergy;
            _slider.value = currentEnergy;

        }

        return currentEnergy;
    }

}
