using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `AmmoSlot`. Inherits from `AtomValueList&lt;AmmoSlot, AmmoSlotEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/AmmoSlot", fileName = "AmmoSlotValueList")]
    public sealed class AmmoSlotValueList : AtomValueList<AmmoSlot, AmmoSlotEvent> { }
}
