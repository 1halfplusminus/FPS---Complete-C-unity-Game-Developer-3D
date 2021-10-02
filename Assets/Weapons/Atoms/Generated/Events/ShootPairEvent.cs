using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ShootPair`. Inherits from `AtomEvent&lt;ShootPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ShootPair", fileName = "ShootPairEvent")]
    public sealed class ShootPairEvent : AtomEvent<ShootPair>
    {
    }
}
