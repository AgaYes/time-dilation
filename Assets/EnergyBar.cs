using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{

[SerializeField] private Slider _slider;
[SerializeField] private float _wasteEnergy;
[SerializeField] private float _getEnergy;

public float _maxEnergy { get; private set; }

 
    private void Awake ()
    {
        _maxEnergy = 1f;
        _slider.value = _maxEnergy;
        gameObject.SetActive(false);
    }

    public float SetEnergy (float currentEnergy)
    {
        gameObject.SetActive(true);
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

            if (currentEnergy >= 1)
            {
                gameObject.SetActive(false);
            }
        }

        return currentEnergy;
    }

}
