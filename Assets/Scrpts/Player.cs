using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _minHealth = 0;
    private int _maxHealth = 100;

    public int Health => _health;

    public void TakeDamage()
    {
        if (_health > _minHealth)
        {
            _health -= 10;
        }

        Debug.Log(_health);
    }

    public void Heal()
    {
        if (_health < _maxHealth)
        {
            _health += 10;
        }
        
        Debug.Log(_health);
    }
}
