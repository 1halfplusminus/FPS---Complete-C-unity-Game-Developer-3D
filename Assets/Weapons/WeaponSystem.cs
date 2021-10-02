using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
public class WeaponSystem : MonoBehaviour
{
    [SerializeField] HitEventReference onHit;
    [SerializeField] ShootEventReference onShoot;
    [SerializeField] EffectEventReference playEffect;

    [SerializeField] WeaponDatabase weaponDatabase;

    [SerializeField] UseWeaponPivot useWeaponPivot;

    private void OnDestroy()
    {
        onHit.Event.Unregister(OnHit);
        onShoot.Event.Unregister(OnShoot);
    }
    void Awake()
    {
        onHit.Event.Register(OnHit);
        onShoot.Event.Register(OnShoot);
    }

    void OnShoot(Shoot shoot)
    {
        var weapon = weaponDatabase.GetEquipedWeapon(shoot.shooter);
        Debug.Log("Weapon " + weapon.Value.Id + " playing shoot effect " + weapon.Value.shootEffect);
        playEffect.Event.Raise(new Effect() { ID = weapon.Value.shootEffect, Target = Vector3.zero, Source = shoot.position, Parent = shoot.shooter });
    }
    void OnHit(Hit hit)
    {
        var weapon = weaponDatabase.GetEquipedWeapon(hit.shoot.shooter);
        playEffect.Event.Raise(new Effect() { ID = weapon.Value.hitEffect, Target = hit.position, Source = hit.shoot.position });
    }
}
