using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Hit`. Inherits from `AtomEvent&lt;Hit&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Hit", fileName = "HitEvent")]
    public sealed class HitEvent : AtomEvent<Hit>
    {
    }
}
