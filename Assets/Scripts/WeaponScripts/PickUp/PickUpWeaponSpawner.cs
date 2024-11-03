using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpWeaponSpawner : MonoBehaviour
{
    [SerializeField] private PickUpWeapon _pickUpWeaponTemplate;
    [SerializeField] private Transform _spawnPoint;

    private void Start()
    {
        Instantiate(_pickUpWeaponTemplate, _spawnPoint.position, Quaternion.identity , transform);
    }
}
