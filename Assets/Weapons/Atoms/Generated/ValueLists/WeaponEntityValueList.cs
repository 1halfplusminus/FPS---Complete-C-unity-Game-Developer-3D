using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `WeaponEntity`. Inherits from `AtomValueList&lt;WeaponEntity, WeaponEntityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/WeaponEntity", fileName = "WeaponEntityValueList")]
    public sealed class WeaponEntityValueList : AtomValueList<WeaponEntity, WeaponEntityEvent> { }
}
