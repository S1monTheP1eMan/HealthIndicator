using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _minHealth = 0;
    private int _maxHealth = 100;
    private int _healthPoints = 10;
    private bool _isHealed;

    public event UnityAction HealthChanged;
    public bool IsHealed => _isHealed;
    public int HealthPoints => _healthPoints;

    public void TryApplyDamage()
    {
        if (_health > _minHealth)
        {
            _health -= _healthPoints;
            _isHealed = false;
            HealthChanged?.Invoke();
        }
    }

    public void TryHeal()
    {
        if (_health < _maxHealth)
        {
            _health += _healthPoints;
            _isHealed = true;
            HealthChanged?.Invoke();
        }
    }
}
