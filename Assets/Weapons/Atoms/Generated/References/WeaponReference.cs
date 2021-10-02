using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Weapon`. Inherits from `AtomReference&lt;Weapon, WeaponPair, WeaponConstant, WeaponVariable, WeaponEvent, WeaponPairEvent, WeaponWeaponFunction, WeaponVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponReference : AtomReference<
        Weapon,
        WeaponPair,
        WeaponConstant,
        WeaponVariable,
        WeaponEvent,
        WeaponPairEvent,
        WeaponWeaponFunction,
        WeaponVariableInstancer>, IEquatable<WeaponReference>
    {
        public WeaponReference() : base() { }
        public WeaponReference(Weapon value) : base(value) { }
        public bool Equals(WeaponReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Weapon other)
        {
            throw new NotImplementedException();
        }
    }
}
