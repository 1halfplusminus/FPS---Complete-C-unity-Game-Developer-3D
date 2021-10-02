using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Shoot`. Inherits from `AtomReference&lt;Shoot, ShootPair, ShootConstant, ShootVariable, ShootEvent, ShootPairEvent, ShootShootFunction, ShootVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ShootReference : AtomReference<
        Shoot,
        ShootPair,
        ShootConstant,
        ShootVariable,
        ShootEvent,
        ShootPairEvent,
        ShootShootFunction,
        ShootVariableInstancer>, IEquatable<ShootReference>
    {
        public ShootReference() : base() { }
        public ShootReference(Shoot value) : base(value) { }
        public bool Equals(ShootReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Shoot other)
        {
            throw new NotImplementedException();
        }
    }
}
