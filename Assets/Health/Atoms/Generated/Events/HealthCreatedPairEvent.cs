using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `HealthCreatedPair`. Inherits from `AtomEvent&lt;HealthCreatedPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/HealthCreatedPair", fileName = "HealthCreatedPairEvent")]
    public sealed class HealthCreatedPairEvent : AtomEvent<HealthCreatedPair>
    {
    }
}
