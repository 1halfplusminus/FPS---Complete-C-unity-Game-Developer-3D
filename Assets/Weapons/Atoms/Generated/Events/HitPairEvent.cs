using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `HitPair`. Inherits from `AtomEvent&lt;HitPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/HitPair", fileName = "HitPairEvent")]
    public sealed class HitPairEvent : AtomEvent<HitPair>
    {
    }
}
