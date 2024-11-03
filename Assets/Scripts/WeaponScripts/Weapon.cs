using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour, IPickable 
{
    [SerializeField] protected float Damage;
    [SerializeField] protected float AttackRange;


    public void Drop()
    {
        gameObject.SetActive(false);
    }

    public void PickUp()
    {
        gameObject.SetActive(true);
    }

    protected abstract void Attack();
}
