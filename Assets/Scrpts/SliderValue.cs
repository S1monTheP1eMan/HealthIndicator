using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void AddHealth()
    {
        StartCoroutine(AddValue());
    }

    public void RemoveHealth()
    {
        StartCoroutine(RemoveValue());
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
