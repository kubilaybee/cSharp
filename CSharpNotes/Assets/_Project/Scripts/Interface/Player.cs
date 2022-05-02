using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable<float>, IKillable
{
    private float _health = 50;

    public float Health 
    { 
        get => _health;
        set => _health=value ; 
    }

    public void Damage(float damageTake)
    {
        _health -= 10;
    }

    public void Kill()
    {
        _health = 0;
    }
}
