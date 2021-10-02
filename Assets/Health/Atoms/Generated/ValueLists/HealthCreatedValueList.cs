using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `HealthCreated`. Inherits from `AtomValueList&lt;HealthCreated, HealthCreatedEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/HealthCreated", fileName = "HealthCreatedValueList")]
    public sealed class HealthCreatedValueList : AtomValueList<HealthCreated, HealthCreatedEvent> { }
}
