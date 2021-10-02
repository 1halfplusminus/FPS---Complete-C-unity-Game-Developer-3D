using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Weapon`. Inherits from `AtomEventInstancer&lt;Weapon, WeaponEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Weapon Event Instancer")]
    public class WeaponEventInstancer : AtomEventInstancer<Weapon, WeaponEvent> { }
}
