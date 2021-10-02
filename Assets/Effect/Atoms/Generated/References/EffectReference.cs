using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Effect`. Inherits from `AtomReference&lt;Effect, EffectPair, EffectConstant, EffectVariable, EffectEvent, EffectPairEvent, EffectEffectFunction, EffectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class EffectReference : AtomReference<
        Effect,
        EffectPair,
        EffectConstant,
        EffectVariable,
        EffectEvent,
        EffectPairEvent,
        EffectEffectFunction,
        EffectVariableInstancer>, IEquatable<EffectReference>
    {
        public EffectReference() : base() { }
        public EffectReference(Effect value) : base(value) { }
        public bool Equals(EffectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Effect other)
        {
            throw new NotImplementedException();
        }
    }
}
