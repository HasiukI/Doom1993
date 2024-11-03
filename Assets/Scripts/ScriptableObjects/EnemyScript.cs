using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Enemy/New Enemy",fileName ="New Enemy")]
public class EnemyScript : ScriptableObject
{
    [SerializeField] private float _health;
    [SerializeField] private float _damage;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _attackRenge;

    public float Health =>_health;
    public float Damage =>_damage;
    public float AttackSpeed =>_attackSpeed;
    public float AttackRenge => _attackRenge;
}
