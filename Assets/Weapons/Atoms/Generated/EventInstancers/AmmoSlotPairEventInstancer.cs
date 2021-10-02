using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `AmmoSlotPair`. Inherits from `AtomEventInstancer&lt;AmmoSlotPair, AmmoSlotPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AmmoSlotPair Event Instancer")]
    public class AmmoSlotPairEventInstancer : AtomEventInstancer<AmmoSlotPair, AmmoSlotPairEvent> { }
}
