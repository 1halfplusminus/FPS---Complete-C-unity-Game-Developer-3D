using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `HealthCreated`. Inherits from `AtomEvent&lt;HealthCreated&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/HealthCreated", fileName = "HealthCreatedEvent")]
    public sealed class HealthCreatedEvent : AtomEvent<HealthCreated>
    {
    }
}
