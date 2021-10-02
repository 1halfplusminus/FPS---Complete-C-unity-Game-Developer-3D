using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `AmmoSlot`. Inherits from `AtomEventReferenceListener&lt;AmmoSlot, AmmoSlotEvent, AmmoSlotEventReference, AmmoSlotUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AmmoSlot Event Reference Listener")]
    public sealed class AmmoSlotEventReferenceListener : AtomEventReferenceListener<
        AmmoSlot,
        AmmoSlotEvent,
        AmmoSlotEventReference,
        AmmoSlotUnityEvent>
    { }
}
