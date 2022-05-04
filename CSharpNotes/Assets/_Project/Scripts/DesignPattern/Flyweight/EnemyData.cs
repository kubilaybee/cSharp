using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy Data")]
public class EnemyData : ScriptableObject
{

    private float _maxSpeed = 10f;          
    private float _attackRange = 40f;       
    private float _attackDamage = 10f;      
    private float _attackInterval = 3f;     

    private int _maxHp = 100;

    // encapsulation
    public float MaxSpeed => _maxSpeed;
    public float AttackRange => _attackRange;
    public float AttackDamage => _attackDamage;
    public float AttackInterval => _attackInterval;
    public float MaxHp => _maxHp;
}
