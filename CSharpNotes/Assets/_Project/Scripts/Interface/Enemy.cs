using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageable<int>,IKillable
{

    public int Health { get; set; }=100;

    public void Damage(int damageTaken)
    {
        Health -= damageTaken;
    }

    public void Kill()
    {
        Health = 0;
    }
}
