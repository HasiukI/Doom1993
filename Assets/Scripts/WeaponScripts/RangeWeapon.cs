using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeWeapon : Weapon
{
    [SerializeField] private Pointer _pointer;

    private readonly Vector3 _rayVector = new Vector3(0.5f, 0.5f, 0);

    protected override void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(_rayVector);

            if (Physics.Raycast(ray, out var hit, AttackRange))
            {
                _pointer.transform.position = hit.point;

                if (hit.transform.TryGetComponent(out Enemy enemy))
                {
                    enemy.TakeDamage(Damage);
                }
            }
        }
    }
}
