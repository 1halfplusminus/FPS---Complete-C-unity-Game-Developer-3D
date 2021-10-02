using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `WeaponEntityPair`. Inherits from `AtomEventInstancer&lt;WeaponEntityPair, WeaponEntityPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/WeaponEntityPair Event Instancer")]
    public class WeaponEntityPairEventInstancer : AtomEventInstancer<WeaponEntityPair, WeaponEntityPairEvent> { }
}
