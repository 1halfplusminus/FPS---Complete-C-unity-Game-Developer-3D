using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `WeaponEntity`. Inherits from `AtomVariable&lt;WeaponEntity, WeaponEntityPair, WeaponEntityEvent, WeaponEntityPairEvent, WeaponEntityWeaponEntityFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/WeaponEntity", fileName = "WeaponEntityVariable")]
    public sealed class WeaponEntityVariable : AtomVariable<WeaponEntity, WeaponEntityPair, WeaponEntityEvent, WeaponEntityPairEvent, WeaponEntityWeaponEntityFunction>
    {
        protected override bool ValueEquals(WeaponEntity other)
        {
            throw new NotImplementedException();
        }
    }
}
