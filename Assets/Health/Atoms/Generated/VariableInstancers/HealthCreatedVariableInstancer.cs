using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `HealthCreated`. Inherits from `AtomVariableInstancer&lt;HealthCreatedVariable, HealthCreatedPair, HealthCreated, HealthCreatedEvent, HealthCreatedPairEvent, HealthCreatedHealthCreatedFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/HealthCreated Variable Instancer")]
    public class HealthCreatedVariableInstancer : AtomVariableInstancer<
        HealthCreatedVariable,
        HealthCreatedPair,
        HealthCreated,
        HealthCreatedEvent,
        HealthCreatedPairEvent,
        HealthCreatedHealthCreatedFunction>
    { }
}
