
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UniRx;
using System;
using System.Linq;

public class UseWeaponBehavior : MonoBehaviour
{

    [SerializeField]
    BoolEventReference onFiring;

    [SerializeField] EntityReference shooter;

    [SerializeField] Vector3Reference shootingFromPosition;

    [SerializeField] Vector3Reference shootingDirection;

    [SerializeField] ShootEventReference onShoot;

    [SerializeField] WeaponReference equipedWeapon;

    long cooldown = 0;
    void OnDestroy()
    {
        onFiring.Event.Unregister(Fire);
    }
    void Start()
    {
        //TODO: Use Weapon Cooldown
        var firingObservable = onFiring.Event.Observe();
        var timer = Observable.Interval(TimeSpan.FromMilliseconds(100));
        timer.TakeUntilDestroy(this).Subscribe((x) => cooldown -= 100);
        firingObservable
                      .TakeUntilDestroy(this)
                      .Subscribe(Fire);
        /*  onFiring.Event.Register(Fire); */
    }

    Shoot CreateShot()
    {
        return new Shoot(shooter.Value.Id, shootingFromPosition.Value, shootingDirection.Value, equipedWeapon.Value.range);
    }
    void Fire(bool value)
    {
        if (value && cooldown <= 0)
        {
            onShoot.Event.Raise(CreateShot());
            cooldown = equipedWeapon.Value.throttle;
        }

    }
}
