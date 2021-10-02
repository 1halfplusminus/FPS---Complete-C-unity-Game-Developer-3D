using UnityEngine;
using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `HealthCreated`. Inherits from `AtomVariable&lt;HealthCreated, HealthCreatedPair, HealthCreatedEvent, HealthCreatedPairEvent, HealthCreatedHealthCreatedFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/HealthCreated", fileName = "HealthCreatedVariable")]
    public sealed class HealthCreatedVariable : AtomVariable<HealthCreated, HealthCreatedPair, HealthCreatedEvent, HealthCreatedPairEvent, HealthCreatedHealthCreatedFunction>
    {
        protected override bool ValueEquals(HealthCreated other)
        {
            throw new NotImplementedException();
        }
    }
}
