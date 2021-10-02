using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Weapon`. Inherits from `AtomVariable&lt;Weapon, WeaponPair, WeaponEvent, WeaponPairEvent, WeaponWeaponFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Weapon", fileName = "WeaponVariable")]
    public sealed class WeaponVariable : AtomVariable<Weapon, WeaponPair, WeaponEvent, WeaponPairEvent, WeaponWeaponFunction>
    {
        protected override bool ValueEquals(Weapon other)
        {
            return other.Id == Value.Id || other.Id == Id;
        }
    }
}
