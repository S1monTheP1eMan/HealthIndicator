using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _minHealth = 0;
    private int _maxHealth = 100;

    public int Health => _health;

    public bool TryTakeDamage()
    {
        if (_health > _minHealth)
        {
            _health -= 10;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TryHeal()
    {
        if (_health < _maxHealth)
        {
            _health += 10;
            return true;
        }
        else
        {
            return false;
        }
    }
}
