using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Weapon`. Inherits from `AtomValueList&lt;Weapon, WeaponEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Weapon", fileName = "WeaponValueList")]
    public sealed class WeaponValueList : AtomValueList<Weapon, WeaponEvent> { }
}
