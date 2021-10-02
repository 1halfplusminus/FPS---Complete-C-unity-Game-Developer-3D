using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Shoot`. Inherits from `AtomValueList&lt;Shoot, ShootEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Shoot", fileName = "ShootValueList")]
    public sealed class ShootValueList : AtomValueList<Shoot, ShootEvent> { }
}
