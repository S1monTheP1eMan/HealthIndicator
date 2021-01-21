using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderValueChanger : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        StartCoroutine(ChangeValue());
    }

    private IEnumerator ChangeValue()
    {
        for (int i = 0; i < _player.HealthPoints; i++)
        {
            if (_player.IsHealed)
            {
                _slider.value++;
                yield return null;
            }
            else
            {
                _slider.value--;
                yield return null;
            }
        }
    }
}
