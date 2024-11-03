using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleeWeapon : Weapon
{
    [SerializeField] private float _attackRange;

    protected override void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, AttackRange);

            foreach (Collider collider in colliders)
            {
                if(collider.TryGetComponent(out Enemy enemy))
                {
                    enemy.TakeDamage(Damage);
                }
            }
        }
    }
}
