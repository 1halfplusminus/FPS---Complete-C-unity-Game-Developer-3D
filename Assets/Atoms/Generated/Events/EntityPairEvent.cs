using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `EntityPair`. Inherits from `AtomEvent&lt;EntityPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/EntityPair", fileName = "EntityPairEvent")]
    public sealed class EntityPairEvent : AtomEvent<EntityPair>
    {
    }
}
