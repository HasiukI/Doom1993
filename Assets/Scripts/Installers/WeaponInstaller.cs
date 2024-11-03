using UnityEngine;
using Zenject;

public class WeaponInstaller : MonoInstaller
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Transform _spawbPoint;

    public override void InstallBindings()
    {
        var weapon = Container.InstantiatePrefabForComponent<Weapon>(_weapon, _spawbPoint.position, _spawbPoint.rotation, _spawbPoint);

           Container
            .Bind<Weapon>()
            .FromInstance(weapon)
            .AsSingle();
    }
}