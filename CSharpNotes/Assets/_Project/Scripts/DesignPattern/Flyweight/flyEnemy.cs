using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyEnemy : MonoBehaviour
{
    [SerializeField] private EnemyData enemyData = null;

    private float _currentSpeed = 0f;
 //   private float _maxSpeed = 10f;          
 //   private float _attackRange = 40f;       
 //   private float _attackDamage = 10f;      
 //   private float _attackInterval = 3f;     

    private int _currentHp = 100;
    //   private int _maxHp = 100;

    private void Start()
    {
        var speed = enemyData.MaxSpeed;
    }
}

