using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `AmmoSlot`. Inherits from `AtomEventInstancer&lt;AmmoSlot, AmmoSlotEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AmmoSlot Event Instancer")]
    public class AmmoSlotEventInstancer : AtomEventInstancer<AmmoSlot, AmmoSlotEvent> { }
}
