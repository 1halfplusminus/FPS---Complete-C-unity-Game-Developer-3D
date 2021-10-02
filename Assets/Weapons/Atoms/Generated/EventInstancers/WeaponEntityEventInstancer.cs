using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `WeaponEntity`. Inherits from `AtomEventInstancer&lt;WeaponEntity, WeaponEntityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/WeaponEntity Event Instancer")]
    public class WeaponEntityEventInstancer : AtomEventInstancer<WeaponEntity, WeaponEntityEvent> { }
}
