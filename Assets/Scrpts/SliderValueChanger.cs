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

    public void TryAddHealth()
    {
        if (_player.TryHeal())
        {
            StartCoroutine(AddValue());
        }
    }

    public void TryRemoveHealth()
    {
        if (_player.TryTakeDamage())
        {
            StartCoroutine(RemoveValue());
        }
    }

    private IEnumerator AddValue()
    {
        for (int i = 0; i < 10; i++)
        {
            _slider.value++;

            yield return null;
        }
    }

    private IEnumerator RemoveValue()
    {
        for (int i = 0; i < 10; i++)
        {
            _slider.value--;

            yield return null;
        }
    }
}
