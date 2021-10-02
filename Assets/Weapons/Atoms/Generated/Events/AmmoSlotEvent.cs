using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `AmmoSlot`. Inherits from `AtomEvent&lt;AmmoSlot&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AmmoSlot", fileName = "AmmoSlotEvent")]
    public sealed class AmmoSlotEvent : AtomEvent<AmmoSlot>
    {
    }
}
