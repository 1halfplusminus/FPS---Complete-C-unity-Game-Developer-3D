using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `HealthCreated`. Inherits from `AtomReference&lt;HealthCreated, HealthCreatedPair, HealthCreatedConstant, HealthCreatedVariable, HealthCreatedEvent, HealthCreatedPairEvent, HealthCreatedHealthCreatedFunction, HealthCreatedVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class HealthCreatedReference : AtomReference<
        HealthCreated,
        HealthCreatedPair,
        HealthCreatedConstant,
        HealthCreatedVariable,
        HealthCreatedEvent,
        HealthCreatedPairEvent,
        HealthCreatedHealthCreatedFunction,
        HealthCreatedVariableInstancer>, IEquatable<HealthCreatedReference>
    {
        public HealthCreatedReference() : base() { }
        public HealthCreatedReference(HealthCreated value) : base(value) { }
        public bool Equals(HealthCreatedReference other) { return base.Equals(other); }
        protected override bool ValueEquals(HealthCreated other)
        {
            throw new NotImplementedException();
        }
    }
}
