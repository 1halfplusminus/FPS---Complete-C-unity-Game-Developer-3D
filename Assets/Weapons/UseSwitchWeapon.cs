using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UniRx;
using System;

public class UseSwitchWeapon : MonoBehaviour
{
    [SerializeField] StringConstant weaponTag;
    [SerializeField] BoolEvent onChangeWeapon;
    [SerializeField] WeaponQueue weapons;
    [SerializeField] WeaponReference currentWeapon;
    // Start is called before the first frame update
    void Awake()
    {
        onChangeWeapon
        .Observe()
        .SkipWhile((changing) => !changing)
        .ThrottleFirst(TimeSpan.FromMilliseconds(250))
        .TakeUntilDisable(this)
        .Subscribe((changing) =>
        {
            if (changing)
            {
                Weapon nextWeapon;
                if (weapons.TryNext(out nextWeapon))
                {
                    weapons.UnEquip(currentWeapon.Value);
                    currentWeapon.Value = nextWeapon;
                }

            }
        });
    }

}
