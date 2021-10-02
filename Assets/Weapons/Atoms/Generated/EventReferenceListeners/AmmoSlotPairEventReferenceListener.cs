using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `AmmoSlotPair`. Inherits from `AtomEventReferenceListener&lt;AmmoSlotPair, AmmoSlotPairEvent, AmmoSlotPairEventReference, AmmoSlotPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AmmoSlotPair Event Reference Listener")]
    public sealed class AmmoSlotPairEventReferenceListener : AtomEventReferenceListener<
        AmmoSlotPair,
        AmmoSlotPairEvent,
        AmmoSlotPairEventReference,
        AmmoSlotPairUnityEvent>
    { }
}
