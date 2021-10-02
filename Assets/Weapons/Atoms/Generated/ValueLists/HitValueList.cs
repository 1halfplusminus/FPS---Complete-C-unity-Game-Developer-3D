using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Hit`. Inherits from `AtomValueList&lt;Hit, HitEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Hit", fileName = "HitValueList")]
    public sealed class HitValueList : AtomValueList<Hit, HitEvent> { }
}
