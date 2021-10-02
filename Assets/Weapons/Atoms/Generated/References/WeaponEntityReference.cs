using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `WeaponEntity`. Inherits from `AtomReference&lt;WeaponEntity, WeaponEntityPair, WeaponEntityConstant, WeaponEntityVariable, WeaponEntityEvent, WeaponEntityPairEvent, WeaponEntityWeaponEntityFunction, WeaponEntityVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class WeaponEntityReference : AtomReference<
        WeaponEntity,
        WeaponEntityPair,
        WeaponEntityConstant,
        WeaponEntityVariable,
        WeaponEntityEvent,
        WeaponEntityPairEvent,
        WeaponEntityWeaponEntityFunction,
        WeaponEntityVariableInstancer>, IEquatable<WeaponEntityReference>
    {
        public WeaponEntityReference() : base() { }
        public WeaponEntityReference(WeaponEntity value) : base(value) { }
        public bool Equals(WeaponEntityReference other) { return base.Equals(other); }
        protected override bool ValueEquals(WeaponEntity other)
        {
            throw new NotImplementedException();
        }
    }
}
