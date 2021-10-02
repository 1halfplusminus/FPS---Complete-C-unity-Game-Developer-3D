using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `AmmoSlotPair`. Inherits from `AtomEvent&lt;AmmoSlotPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AmmoSlotPair", fileName = "AmmoSlotPairEvent")]
    public sealed class AmmoSlotPairEvent : AtomEvent<AmmoSlotPair>
    {
    }
}
