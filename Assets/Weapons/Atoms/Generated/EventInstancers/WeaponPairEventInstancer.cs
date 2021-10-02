using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `WeaponPair`. Inherits from `AtomEventInstancer&lt;WeaponPair, WeaponPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/WeaponPair Event Instancer")]
    public class WeaponPairEventInstancer : AtomEventInstancer<WeaponPair, WeaponPairEvent> { }
}
