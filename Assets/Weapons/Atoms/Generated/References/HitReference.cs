using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Hit`. Inherits from `AtomReference&lt;Hit, HitPair, HitConstant, HitVariable, HitEvent, HitPairEvent, HitHitFunction, HitVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HitReference : AtomReference<
        Hit,
        HitPair,
        HitConstant,
        HitVariable,
        HitEvent,
        HitPairEvent,
        HitHitFunction,
        HitVariableInstancer>, IEquatable<HitReference>
    {
        public HitReference() : base() { }
        public HitReference(Hit value) : base(value) { }
        public bool Equals(HitReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Hit other)
        {
            throw new NotImplementedException();
        }
    }
}
