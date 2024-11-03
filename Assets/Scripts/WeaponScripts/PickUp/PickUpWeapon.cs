using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PickUpWeapon : MonoBehaviour, IPickable
{
    [SerializeField] private Weapon _weapon;

    
    public Weapon WeaponToPickUp()
    {
        return _weapon;
    }

    public void Drop()
    {
       gameObject.SetActive(false);
    }

    public void PickUp()
    {
        gameObject.SetActive(false);
    }
}
