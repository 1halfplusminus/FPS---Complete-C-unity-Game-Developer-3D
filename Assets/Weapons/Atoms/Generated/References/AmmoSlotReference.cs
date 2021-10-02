using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `AmmoSlot`. Inherits from `AtomReference&lt;AmmoSlot, AmmoSlotPair, AmmoSlotConstant, AmmoSlotVariable, AmmoSlotEvent, AmmoSlotPairEvent, AmmoSlotAmmoSlotFunction, AmmoSlotVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AmmoSlotReference : AtomReference<
        AmmoSlot,
        AmmoSlotPair,
        AmmoSlotConstant,
        AmmoSlotVariable,
        AmmoSlotEvent,
        AmmoSlotPairEvent,
        AmmoSlotAmmoSlotFunction,
        AmmoSlotVariableInstancer>, IEquatable<AmmoSlotReference>
    {
        public AmmoSlotReference() : base() { }
        public AmmoSlotReference(AmmoSlot value) : base(value) { }
        public bool Equals(AmmoSlotReference other) { return base.Equals(other); }
        protected override bool ValueEquals(AmmoSlot other)
        {
            throw new NotImplementedException();
        }
    }
}
