using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Weapon`. Inherits from `AtomBaseVariable&lt;Weapon&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Weapon", fileName = "WeaponConstant")]
    public sealed class WeaponConstant : AtomBaseVariable<Weapon> { }
}
